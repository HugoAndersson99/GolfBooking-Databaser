using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GolfBooking
{
    public partial class MainPage : Form
    {
        LoginView LoginView;
        GolfUser user;
        Dictionary<int, GolfUser> usersUnder30Hcp;
        Dictionary<int, GolfClub> clubs;
        Dictionary<int, GolfClub> searchClubs;
        Dictionary<int, UserRound> allUserRounds;
        Dictionary<int, UserRound> rounds;
        Dictionary<int, GolfUser> golfUsers;
        Dictionary<int, GolfCourse> courses;
        DatabaseConnection databaseConnection = new DatabaseConnection();
        public MainPage(GolfUser golfUser, LoginView loginView)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Images/Golfgrass.jpg");
            user = golfUser;
            LoginView = loginView;

            Run();
        }
        public void Run()
        {
            golfUsers = databaseConnection.GetGolfUsers();

            clubs = databaseConnection.GetClubs();

            courses = databaseConnection.GetCourses(clubs);

            allUserRounds = databaseConnection.GetAllUserRounds(golfUsers, courses);

            rounds = databaseConnection.GetUserRounds(user, courses);



            databaseConnection.GetUserClubs(golfUsers, clubs);

            foreach (GolfUser user in golfUsers.Values)
            {
                UpdateHandicap(user);
            }

            usersUnder30Hcp = databaseConnection.GetUserUnder30Handicap(golfUsers);


            PopulateClubComboBox();
            PopulateUserRounds();
            PopulateMemberships();
            ShowGolfUser(user);
            regRoundPanel.BringToFront();
            userHcpLabel.Text = user.GolfHandicap.ToString();
        }
        public void PopulateClubComboBox()
        {
            foreach (GolfClub club in clubs.Values)
            {
                clubComboBox.Items.Add(club.ClubName);

            }
        }

        public void PopulateCourseComboBox(GolfClub golfClub)
        {
            courseComboBox.Items.Clear();
            foreach (GolfCourse course in golfClub.Courses)
            {
                courseComboBox.Items.Add(course.CourseName);
            }
        }
        public void PopulateUserRounds()
        {
            roundsListbox.Items.Clear();
            foreach (UserRound userRound in rounds.Values)
            {
                int strokes = GetAmountStrokes(userRound);
                userRound.TotalStrokes = strokes;
                string amountStrokes = strokes.ToString();
                roundsListbox.Items.Add(userRound.UserRoundID + " " + userRound.GolfCourse.GolfClub.ClubName + " " + userRound.GolfCourse.CourseName + " " + amountStrokes);
            }
            PopulateBestRounds();
        }
        public void PopulateScorecard()
        {
            string selectedClub = clubComboBox.SelectedItem.ToString();
            string selectedCourse = courseComboBox.SelectedItem.ToString();
            foreach (GolfClub golfClub in clubs.Values)
            {
                string club = golfClub.ClubName;
                if (selectedClub == club)
                {
                    foreach (GolfCourse course in golfClub.Courses)
                    {
                        if (selectedCourse == course.CourseName)
                        {
                            par1Label.Text = course.Hole1Par.ToString();
                            par2Label.Text = course.Hole2Par.ToString();
                            par3Label.Text = course.Hole3Par.ToString();
                            par4Label.Text = course.Hole4Par.ToString();
                            par5Label.Text = course.Hole5Par.ToString();
                            par6Label.Text = course.Hole6Par.ToString();
                            par7Label.Text = course.Hole7Par.ToString();
                            par8Label.Text = course.Hole8Par.ToString();
                            par9Label.Text = course.Hole9Par.ToString();
                            par10Label.Text = course.Hole10Par.ToString();
                            par11Label.Text = course.Hole11Par.ToString();
                            par12Label.Text = course.Hole12Par.ToString();
                            par13Label.Text = course.Hole13Par.ToString();
                            par14Label.Text = course.Hole14Par.ToString();
                            par15Label.Text = course.Hole15Par.ToString();
                            par16Label.Text = course.Hole16Par.ToString();
                            par17Label.Text = course.Hole17Par.ToString();
                            par18Label.Text = course.Hole18Par.ToString();
                        }
                    }
                }
            }

        }
        private void UpdateUsers()
        {
            golfUsers = databaseConnection.GetGolfUsers();
            clubs = databaseConnection.GetClubs();
            databaseConnection.GetUserClubs(golfUsers, clubs);
            usersUnder30Hcp = databaseConnection.GetUserUnder30Handicap(golfUsers);
        }
        private void ShowGolfUser(GolfUser user)
        {
            userInfoLabel.Text = user.FirstName + " " + user.LastName;
            string userHandicap = user.GolfHandicap.ToString();
            userHcpLabel.Text = userHandicap;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void regRoundButton_Click(object sender, EventArgs e)
        {
            regRoundPanel.BringToFront();
        }

        private void prevRoundButton_Click(object sender, EventArgs e)
        {
            pastRoundsPanel.BringToFront();
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                PopulateScorecard();
            }

        }

        public int GetAmountStrokes(UserRound userRound)
        {
            int totalStrokes = userRound.Hole1Strokes + userRound.Hole2Strokes + userRound.Hole3Strokes + userRound.Hole4Strokes + userRound.Hole5Strokes + userRound.Hole6Strokes +
                userRound.Hole7Strokes + userRound.Hole8Strokes + userRound.Hole9Strokes + userRound.Hole10Strokes + userRound.Hole11Strokes + userRound.Hole12Strokes +
                userRound.Hole13Strokes + userRound.Hole14Strokes + userRound.Hole15Strokes + userRound.Hole16Strokes + userRound.Hole17Strokes + userRound.Hole18Strokes;
            return totalStrokes;
        }



        private bool ControlBoxes()
        {
            if (hål1SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 1");
                return false;
            }
            if (hål2SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 2");
                return false;
            }
            if (hål3SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 3");
                return false;
            }
            if (hål4SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 4");
                return false;
            }
            if (hål5SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 5");
                return false;
            }
            if (hål6SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 6");
                return false;
            }
            if (hål7SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 7");
                return false;
            }
            if (hål8SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 8");
                return false;
            }
            if (hål9SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 9");
                return false;
            }
            if (hål10SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 10");
                return false;
            }
            if (hål11SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 11");
                return false;
            }
            if (hål12SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 12");
                return false;
            }
            if (hål13SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 13");
                return false;
            }
            if (hål14SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 14");
                return false;
            }
            if (hål15SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 15");
                return false;
            }
            if (hål16SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 16");
                return false;
            }
            if (hål17SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 17");
                return false;
            }
            if (hål18SlagBox.Text == null)
            {
                MessageBox.Show("Vänligen fyll i dina slag för hål 18");
                return false;
            }

            return true;
        }
        private int GetCourseId()
        {
            int courseId = 0;
            string boxCourse = courseComboBox.SelectedItem.ToString();
            foreach (GolfCourse golfCourse in courses.Values)
            {
                if (golfCourse.CourseName == boxCourse)
                {
                    courseId = golfCourse.GolfCourseID;
                    return courseId;
                }

            }
            return courseId;
        }

        private void registerRoundButton_Click(object sender, EventArgs e)
        {

            int hole1 = 0;
            int hole2 = 0;
            int hole3 = 0;
            int hole4 = 0;
            int hole5 = 0;
            int hole6 = 0;
            int hole7 = 0;
            int hole8 = 0;
            int hole9 = 0;
            int hole10 = 0;
            int hole11 = 0;
            int hole12 = 0;
            int hole13 = 0;
            int hole14 = 0;
            int hole15 = 0;
            int hole16 = 0;
            int hole17 = 0;
            int hole18 = 0;
            bool b = ControlBoxes();
            if (b == false)
            {

                return;
            }
            try
            {


                hole1 = Convert.ToInt32(hål1SlagBox.Text);
                hole2 = Convert.ToInt32(hål2SlagBox.Text);
                hole3 = Convert.ToInt32(hål3SlagBox.Text);
                hole4 = Convert.ToInt32(hål4SlagBox.Text);
                hole5 = Convert.ToInt32(hål5SlagBox.Text);
                hole6 = Convert.ToInt32(hål6SlagBox.Text);
                hole7 = Convert.ToInt32(hål7SlagBox.Text);
                hole8 = Convert.ToInt32(hål8SlagBox.Text);
                hole9 = Convert.ToInt32(hål9SlagBox.Text);
                hole10 = Convert.ToInt32(hål10SlagBox.Text);
                hole11 = Convert.ToInt32(hål11SlagBox.Text);
                hole12 = Convert.ToInt32(hål12SlagBox.Text);
                hole13 = Convert.ToInt32(hål13SlagBox.Text);
                hole14 = Convert.ToInt32(hål14SlagBox.Text);
                hole15 = Convert.ToInt32(hål15SlagBox.Text);
                hole16 = Convert.ToInt32(hål16SlagBox.Text);
                hole17 = Convert.ToInt32(hål17SlagBox.Text);
                hole18 = Convert.ToInt32(hål18SlagBox.Text);

            }
            catch
            {
                MessageBox.Show("Vänligen fyll i dina slag med nummer i ALLA boxar");
            }
            int courseId = GetCourseId();
            UserRound newUserRound = databaseConnection.AddNewRound(user, courses, courseId, user.GolfUserID, hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9, hole10,
                hole11, hole12, hole13, hole14, hole15, hole16, hole17, hole18);

            rounds.Add(newUserRound.UserRoundID, newUserRound);
            UpdateRounds();
            UpdateHandicap(user);
            UpdateUsers();
            clubComboBox.SelectedIndex = 0;
            courseComboBox.SelectedIndex = 0;
            ClearScorecard();

        }
        public void UpdateRounds()
        {
            rounds.Clear();
            rounds = databaseConnection.GetUserRounds(user, courses);
            PopulateUserRounds();
            PopulateBestRounds();
        }
        public void PopulateBestRounds()
        {
            bestRoundsListBox.Items.Clear();
            int roundsAmount = 0;
            int bestRoundsStrokes = 0;
            int handicap = 0;
            var sortedRounds = rounds.OrderBy(p => p.Value.TotalStrokes);
            var lowestRounds = sortedRounds.Take(4);
            foreach (var round in lowestRounds)
            {

                bestRoundsListBox.Items.Add(round.Value.UserRoundID + " " + round.Value.GolfCourse.GolfClub.ClubName + " " + round.Value.GolfCourse.CourseName +
                    " " + round.Value.TotalStrokes);
                bestRoundsStrokes += round.Value.TotalStrokes;
                roundsAmount++;
            }


        }
        private void UpdateHandicap(GolfUser golfUser)
        {

            int roundsAmount = 0;
            int bestRoundsStrokes = 0;
            int handicap = 0;

            var sortedRounds = golfUser.userRounds.OrderBy(p => p.TotalStrokes);
            var lowestRounds = sortedRounds.Take(4);
            if (rounds.Count == 0)
            {
                handicap = 54;
            }
            else
            {


                foreach (var round in lowestRounds)
                {
                    bestRoundsStrokes += round.TotalStrokes;
                    roundsAmount++;
                }
                handicap = bestRoundsStrokes / roundsAmount - 72;
                if (handicap > 54)
                {
                    handicap = 54;
                }
            }
            bool succes = databaseConnection.UpdateHandicap(golfUser, handicap);
            if (succes)
            {
                golfUser.GolfHandicap = handicap;

            }
        }


        private void clubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseComboBox.SelectedItem = null;
            string selectedClub = clubComboBox.SelectedItem.ToString();
            foreach (GolfClub club in clubs.Values)
            {
                if (selectedClub == club.ClubName)
                {
                    PopulateCourseComboBox(club);
                }
            }
        }

        private void clubInfoButton_Click(object sender, EventArgs e)
        {
            clubListBox.Items.Clear();
            clubMembersListBox.Items.Clear();
            clubInfoPanel.BringToFront();
        }



        private void ClearScorecard()
        {
            hål1SlagBox.Text = null;
            hål2SlagBox.Text = null;
            hål3SlagBox.Text = null;
            hål4SlagBox.Text = null;
            hål5SlagBox.Text = null;
            hål6SlagBox.Text = null;
            hål7SlagBox.Text = null;
            hål8SlagBox.Text = null;
            hål9SlagBox.Text = null;
            hål10SlagBox.Text = null;
            hål11SlagBox.Text = null;
            hål12SlagBox.Text = null;
            hål13SlagBox.Text = null;
            hål14SlagBox.Text = null;
            hål15SlagBox.Text = null;
            hål16SlagBox.Text = null;
            hål17SlagBox.Text = null;
            hål18SlagBox.Text = null;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginView.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = clubSearchTextBox.Text;
            if (searchText == "")
            {
                MessageBox.Show("OKEJ");
                return;
            }

            searchClubs = databaseConnection.GetClubsWithName(searchText);
            PopulateClubListBox();
        }
        public void PopulateClubListBox()
        {
            clubListBox.Items.Clear();
            foreach (GolfClub club in searchClubs.Values)
            {
                clubListBox.Items.Add(club.ClubName);

            }
        }

        public void PopulateMemberships()
        {
            clubsListBox.Items.Clear();
            foreach (GolfClub golfClub in clubs.Values)
            {
                foreach (GolfUser users in golfClub.Users)
                {
                    if (users.GolfUserID == user.GolfUserID)
                    {
                        clubsListBox.Items.Add(golfClub.ClubName);
                    }
                }
            }

        }

        private void clubListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubMembersListBox.Items.Clear();
            string chosenClub = clubListBox.SelectedItem.ToString();
            foreach (GolfClub club in clubs.Values)
            {
                if (chosenClub == club.ClubName)
                {
                    foreach (GolfUser users in club.Users)
                    {
                        clubMembersListBox.Items.Add(users.FirstName + " " + users.LastName + " HCP: " + users.GolfHandicap);
                    }
                }
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            clubListBox.Items.Clear();
            foreach (GolfClub club in clubs.Values)
            {
                clubListBox.Items.Add(club.ClubName);

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int roundId = 0;
            bool success = false;
            if (roundsListbox.SelectedItem == null)
            {
                return;
            }
            string selectedRound = roundsListbox.SelectedItem.ToString();
            foreach (UserRound userRound in rounds.Values)
            {
                string round = userRound.UserRoundID + " " + userRound.GolfCourse.GolfClub.ClubName + " " + userRound.GolfCourse.CourseName + " " + userRound.TotalStrokes;
                if (round == selectedRound)
                {
                    success = databaseConnection.DeleteRound(userRound.UserRoundID);
                    roundId = userRound.UserRoundID;
                }
            }
            if (success == true)
            {
                roundsListbox.Items.RemoveAt(roundsListbox.SelectedIndex);
                roundsListbox.Refresh();
                rounds.Remove(roundId);
                PopulateBestRounds();
                UpdateHandicap(user);
            }
            else
            {
                MessageBox.Show("Något gick fel!");
            }
        }

        private void showAllMembersButton_Click(object sender, EventArgs e)
        {
            clubMembersListBox.Items.Clear();
            foreach (GolfUser users in golfUsers.Values)
            {
                clubMembersListBox.Items.Add(users.FirstName + " " + users.LastName + " HCP: " + users.GolfHandicap);
            }
        }

        private void showHandicapButton_Click(object sender, EventArgs e)
        {
            clubMembersListBox.Items.Clear();
            foreach (GolfUser users in usersUnder30Hcp.Values)
            {
                clubMembersListBox.Items.Add(users.FirstName + " " + users.LastName + " HCP: " + users.GolfHandicap);
            }
        }
    }
}
