using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBooking
{
    public class GolfCourse
    {
        

        public int GolfCourseID { get; set; }
        public int GolfClubID { get; set; }
        public string CourseName { get; set; }
        
        public int Hole1Par{ get; set; }
        public int Hole2Par{ get; set; }
        public int Hole3Par{ get; set; }
        public int Hole4Par{ get; set; }
        public int Hole5Par{ get; set; }
        public int Hole6Par{ get; set; }
        public int Hole7Par{ get; set; }
        public int Hole8Par{ get; set; }
        public int Hole9Par{ get; set; }
        public int Hole10Par { get; set; }
        public int Hole11Par { get; set; }
        public int Hole12Par { get; set; }
        public int Hole13Par { get; set; }
        public int Hole14Par { get; set; }
        public int Hole15Par { get; set; }
        public int Hole16Par { get; set; }
        public int Hole17Par { get; set; }
        public int Hole18Par { get; set; }
        public GolfClub GolfClub { get; set; }

        public GolfCourse(int golfCourseID, int golfClubID, string courseName, int hole1Par, int hole2Par, int hole3Par,
            int hole4Par, int hole5Par, int hole6Par, int hole7Par, int hole8Par, int hole9Par, int hole10Par, int hole11Par,
            int hole12Par, int hole13Par, int hole14Par, int hole15Par, int hole16Par, int hole17Par, int hole18Par)
        {
            GolfCourseID = golfCourseID;
            GolfClubID = golfClubID;
            CourseName = courseName;
            
            Hole1Par = hole1Par;
            Hole2Par = hole2Par;
            Hole3Par = hole3Par;
            Hole4Par = hole4Par;
            Hole5Par = hole5Par;
            Hole6Par = hole6Par;
            Hole7Par = hole7Par;
            Hole8Par = hole8Par;
            Hole9Par = hole9Par;
            Hole10Par = hole10Par;
            Hole11Par = hole11Par;
            Hole12Par = hole12Par;
            Hole13Par = hole13Par;
            Hole14Par = hole14Par;
            Hole15Par = hole15Par;
            Hole16Par = hole16Par;
            Hole17Par = hole17Par;
            Hole18Par = hole18Par;
        }
    }
}
