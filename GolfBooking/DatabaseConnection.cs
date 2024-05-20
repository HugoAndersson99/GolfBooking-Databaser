using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Reflection.Metadata.BlobBuilder;


namespace GolfBooking
{
    public class DatabaseConnection
    {
        string server = "localhost";
        string database = "golfbooking";
        string username = "GolfBookingUser";
        string password = "GolfPassword";

        string connectionString = "";

        public DatabaseConnection(string server, string database, string username, string password)
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
            Console.WriteLine("ConnectionString: " + connectionString);
        }

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            Console.WriteLine("ConnectionString: " + connectionString);
        }

        public Dictionary<int, GolfUser> GetGolfUsers()
        {
            Dictionary<int, GolfUser> golfUsers = new Dictionary<int, GolfUser>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM GolfUser";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                GolfUser golfUser = new GolfUser((int)reader["UserId"], (string)reader["UserPassword"],
                    (string)reader["Email"], (string)reader["FirstName"], (string)reader["LastName"],
                    (int)reader["GolfHandicap"]);
                golfUsers.Add(golfUser.GolfUserID, golfUser);
            }
            mySqlConnection.Close();
            
            return golfUsers;
        }

        public GolfUser AddNewGolfUser(string email, string password, string firstName, string lastName)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "CALL CreateNewGolfUser(\"" + email + "\", \"" + password + "\",\"" + firstName + "\", \"" + lastName + "\")";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            reader.Read();

            int golfUserId = (int)reader["NewID"];


            GolfUser golfUser = new GolfUser(golfUserId, password, email, firstName, lastName, 54);

            mySqlConnection.Close();
            MessageBox.Show("Eftersom du är ny användare kommer du få max handicap! (54)");
            return golfUser;
        }
        public UserRound AddNewRound(GolfUser chosenUser, Dictionary<int, GolfCourse> courses, int courseId, int userId, int hole1, int hole2, int hole3, int hole4, int hole5, int hole6, int hole7, int hole8, int hole9, int hole10,
            int hole11, int hole12, int hole13, int hole14, int hole15, int hole16, int hole17, int hole18)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "CALL CreateNewRound(\"" + courseId + "\", \"" + userId + "\",  \"" + hole1 + "\", \"" + hole2 + "\", \"" + hole3 + "\", \"" + hole4 + "\", \"" + hole5 + "\", \"" + hole6 + "\", \"" + hole7 + "\", \"" + hole8 + "\", \"" + hole9 + "\", \"" + hole10 + "\", \"" + hole11 + "\", \"" + hole12 + "\", \"" + hole13 + "\", \"" + hole14 + "\", \"" + hole15 + "\", \"" + hole16 + "\", \"" + hole17 + "\", \"" + hole18 + "\")";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int roundId = (int)reader["NewID"];

            UserRound userRound = new UserRound(roundId, hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9,
                hole10, hole11, hole12, hole13, hole14, hole15, hole16, hole17, hole18);
            GolfCourse course = courses[courseId];

            userRound.GolfCourse = course;
            userRound.GolfUser = chosenUser;

            return userRound;
        }
        
        public Dictionary<int, GolfClub> GetClubs()
        {
            Dictionary<int, GolfClub> clubs = new Dictionary<int, GolfClub> ();
            Dictionary<int, GolfCourse> courses = new Dictionary<int, GolfCourse> ();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM GolfClub";

            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                GolfClub golfClub = new GolfClub((int)reader["ClubID"], (string)reader["ClubName"], (string)reader["Location"]);
                clubs.Add(golfClub.ClubID, golfClub);
            }

            query = "SELECT * FROM GolfCourse";
            mySqlCommand = new MySqlCommand (query, connection);

            reader.Close();

            reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                GolfCourse golfCourse = new GolfCourse((int)reader["GolfCoursedID"], (int)reader["GolfClubID"], (string)reader["CourseName"], (int)reader["Hole1Par"], (int)reader["Hole2Par"],
                    (int)reader["Hole3Par"], (int)reader["Hole4Par"], (int)reader["Hole5Par"], (int)reader["Hole6Par"], (int)reader["Hole7Par"], (int)reader["Hole8Par"], (int)reader["Hole9Par"],
                    (int)reader["Hole10Par"], (int)reader["Hole11Par"], (int)reader["Hole12Par"], (int)reader["Hole13Par"], (int)reader["Hole14Par"], (int)reader["Hole15Par"],
                    (int)reader["Hole16Par"], (int)reader["Hole17Par"], (int)reader["Hole18Par"]);

                GolfClub clubWithCourse = clubs[(int)reader["GolfClubID"]];

                clubWithCourse.Courses.Add(golfCourse);
                golfCourse.GolfClub = clubWithCourse;
                courses.Add(golfCourse.GolfCourseID, golfCourse);
            }

            connection.Close();

            return clubs;
            
        }
        public Dictionary<int, GolfCourse> GetCourses(Dictionary<int, GolfClub> clubs)
        {
            
            Dictionary<int, GolfCourse> courses = new Dictionary<int, GolfCourse>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM GolfCourse";

            MySqlCommand mySqlCommand = new MySqlCommand(query, connection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();


            

            

            while (reader.Read())
            {
                GolfCourse golfCourse = new GolfCourse((int)reader["GolfCoursedID"], (int)reader["GolfClubID"], (string)reader["CourseName"], (int)reader["Hole1Par"], (int)reader["Hole2Par"],
                    (int)reader["Hole3Par"], (int)reader["Hole4Par"], (int)reader["Hole5Par"], (int)reader["Hole6Par"], (int)reader["Hole7Par"], (int)reader["Hole8Par"], (int)reader["Hole9Par"],
                    (int)reader["Hole10Par"], (int)reader["Hole11Par"], (int)reader["Hole12Par"], (int)reader["Hole13Par"], (int)reader["Hole14Par"], (int)reader["Hole15Par"],
                    (int)reader["Hole16Par"], (int)reader["Hole17Par"], (int)reader["Hole18Par"]);

                int clubId = (int)reader["GolfClubID"];
                GolfClub club = clubs[clubId];

                golfCourse.GolfClub = club;
                courses.Add(golfCourse.GolfCourseID, golfCourse);
            }

            connection.Close();

            return courses;

        }


        public Dictionary<int, UserRound> GetUserRounds(GolfUser chosenUser, Dictionary<int, GolfCourse> courses)
        {
            Dictionary<int, UserRound> userRounds = new Dictionary<int, UserRound>();


            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM UserRound WHERE GolfUserID = @GolfUserID";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@GolfUserID", chosenUser.GolfUserID.ToString());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                UserRound userRound = new UserRound((int)reader["RoundID"], (int)reader["Hole1Strokes"], (int)reader["Hole2Strokes"],
                    (int)reader["Hole3Strokes"], (int)reader["Hole4Strokes"], (int)reader["Hole5Strokes"], (int)reader["Hole6Strokes"], (int)reader["Hole7Strokes"],
                    (int)reader["Hole8Strokes"], (int)reader["Hole9Strokes"], (int)reader["Hole10Strokes"], (int)reader["Hole11Strokes"],
                    (int)reader["Hole12Strokes"], (int)reader["Hole13Strokes"], (int)reader["Hole14Strokes"], (int)reader["Hole15Strokes"],
                    (int)reader["Hole16Strokes"], (int)reader["Hole17Strokes"], (int)reader["Hole18Strokes"]);

                int courseId = (int)reader["GolfCourseID"];
                int userId = (int)reader["GolfUserID"];

                GolfCourse course = courses[courseId];
                //GolfUser user = u[userId];

                userRound.GolfCourse = course;
                
                
                    userRound.GolfUser = chosenUser;
                
                

                chosenUser.userRounds.Add(userRound);
                userRounds.Add(userRound.UserRoundID, userRound);
            }
            connection.Close();
            return userRounds;
        }
        public Dictionary<int, UserRound> GetAllUserRounds(Dictionary<int, GolfUser> users, Dictionary<int, GolfCourse> courses)
        {
            Dictionary<int, UserRound> allRounds = new Dictionary<int, UserRound>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM UserRound";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                UserRound userRound = new UserRound((int)reader["RoundID"], (int)reader["Hole1Strokes"], (int)reader["Hole2Strokes"],
                    (int)reader["Hole3Strokes"], (int)reader["Hole4Strokes"], (int)reader["Hole5Strokes"], (int)reader["Hole6Strokes"], (int)reader["Hole7Strokes"],
                    (int)reader["Hole8Strokes"], (int)reader["Hole9Strokes"], (int)reader["Hole10Strokes"], (int)reader["Hole11Strokes"],
                    (int)reader["Hole12Strokes"], (int)reader["Hole13Strokes"], (int)reader["Hole14Strokes"], (int)reader["Hole15Strokes"],
                    (int)reader["Hole16Strokes"], (int)reader["Hole17Strokes"], (int)reader["Hole18Strokes"]);

                int courseId = (int)reader["GolfCourseID"];
                int userId = (int)reader["GolfUserID"];

                GolfCourse course = courses[courseId];
                GolfUser user = users[userId];
                

                userRound.GolfCourse = course;


                userRound.GolfUser = user;



                user.userRounds.Add(userRound);
                allRounds.Add(userRound.UserRoundID, userRound);
                
            }
            connection.Close();
            return allRounds;
        }
        
        public void GetUserClubs(Dictionary<int, GolfUser> golfUsers, Dictionary<int, GolfClub> golfClubs)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM UsersInClubs;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int userId = (int)reader["UserID"];
                int clubId = (int)reader["ClubID"];

                GolfClub club = golfClubs[clubId];
                GolfUser user = golfUsers[userId];

                user.clubs.Add(club);
                club.Users.Add(user);
            }

            mySqlConnection.Close();
        }
        public Dictionary<int,GolfUser> GetUserUnder30Handicap(Dictionary<int, GolfUser> golfUser)
        {
            Dictionary<int, GolfUser> userUnder30hcp = new Dictionary<int, GolfUser>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM HandicapsUnder30;";

            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int userId = (int)reader["UserID"];

                GolfUser golfUser1 = golfUser[userId];

                userUnder30hcp.Add(golfUser1.GolfUserID, golfUser1);
            }
            mySqlConnection.Close();
            return userUnder30hcp;
        }
        public void AssignUserToClub(GolfUser user, int clubKey) 
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO UsersInClubs VALUES (\"" + user.GolfUserID + "\", \"" + clubKey + "\")";

            MySqlCommand command = new MySqlCommand( query, connection);
            int rowsAffected = command.ExecuteNonQuery();

            connection.Close();
        }
        public bool UpdateHandicap(GolfUser user, int newHandicap)
        {
            string query = "UPDATE GolfUser " +
                           "SET GolfHandicap = \"" + newHandicap + "\" " +
                           "WHERE UserID = " + user.GolfUserID + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            if(0 < rowsAffected)
            {
                return true;
            }
            return false;
        }
        public Dictionary<int, GolfClub> GetClubsWithName(string searchText)
        {
            string query = "CALL SearchGolfClub(\"" + searchText + "\");";
            return CallClubs(query);
        }
        public Dictionary<int,GolfClub> CallClubs(string query)
        {
            Dictionary<int, GolfClub> clubDictionary = new Dictionary<int, GolfClub>();
            Dictionary<int, GolfClub> allClubs = GetClubs();

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                GolfClub golfClub = allClubs[(int)reader["ClubID"]];
                
                clubDictionary.Add(golfClub.ClubID, golfClub);
            }

            conn.Close();

            return clubDictionary;
        }
        public bool DeleteRound(int roundId)
        {
            string query = "CALL RemoveRound(" + roundId + ")";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                reader.Read();

                if ((string)reader["result"] != null)
                {
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            connection.Close();
            return false;
        }
        
    }
    
}
