using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBooking
{
    public class GolfClub
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        public string Location { get; set; }
        public List<GolfCourse> Courses { get; set; } = new List<GolfCourse>();
        public List<GolfUser> Users { get; set; } = new List<GolfUser>();

        public GolfClub(int clubID, string clubName, string location)
        {
            ClubID = clubID;
            ClubName = clubName;
            Location = location;
        }
    }
}
