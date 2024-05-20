using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBooking
{
    public class GolfUser
    {
        public int GolfUserID { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GolfHandicap { get; set; }
        public List<UserRound> userRounds { get; set; } = new List<UserRound>();

        public List<GolfClub> clubs { get; set; } = new List<GolfClub>();

        public GolfUser (int golfUserID, string userPassword, string email, string firstName, string lastName, int golfHandicap)
        {
            GolfUserID = golfUserID;
            UserPassword = userPassword;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            GolfHandicap = golfHandicap;
        }
    }
}
