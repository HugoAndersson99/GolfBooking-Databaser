using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfBooking
{
    public class UserRound
    {
        

        public int UserRoundID { get; set; }
        public int Hole1Strokes { get; set; }
        public int Hole2Strokes { get; set; }
        public int Hole3Strokes { get; set; }
        public int Hole4Strokes { get; set; }
        public int Hole5Strokes { get; set; }
        public int Hole6Strokes { get; set; }
        public int Hole7Strokes { get; set; }
        public int Hole8Strokes { get; set; }
        public int Hole9Strokes { get; set; }
        public int Hole10Strokes { get; set; }
        public int Hole11Strokes { get; set; }
        public int Hole12Strokes { get; set; }
        public int Hole13Strokes { get; set; }
        public int Hole14Strokes { get; set; }
        public int Hole15Strokes { get; set; }
        public int Hole16Strokes { get; set; }
        public int Hole17Strokes { get; set; }
        public int Hole18Strokes { get; set; }
        public GolfCourse GolfCourse { get; set; }
        public GolfUser GolfUser { get; set; }
        public int TotalStrokes { get; set; }
        public UserRound(int userRoundID, int hole1Strokes, int hole2Strokes, int hole3Strokes, int hole4Strokes, int hole5Strokes,
            int hole6Strokes, int hole7Strokes, int hole8Strokes, int hole9Strokes, int hole10Strokes, int hole11Strokes, int hole12Strokes,
            int hole13Strokes, int hole14Strokes, int hole15Strokes, int hole16Strokes, int hole17Strokes, int hole18Strokes)
        {
            UserRoundID = userRoundID;
            Hole1Strokes = hole1Strokes;
            Hole2Strokes = hole2Strokes;
            Hole3Strokes = hole3Strokes;
            Hole4Strokes = hole4Strokes;
            Hole5Strokes = hole5Strokes;
            Hole6Strokes = hole6Strokes;
            Hole7Strokes = hole7Strokes;
            Hole8Strokes = hole8Strokes;
            Hole9Strokes = hole9Strokes;
            Hole10Strokes = hole10Strokes;
            Hole11Strokes = hole11Strokes;
            Hole12Strokes = hole12Strokes;
            Hole13Strokes = hole13Strokes;
            Hole14Strokes = hole14Strokes;
            Hole15Strokes = hole15Strokes;
            Hole16Strokes = hole16Strokes;
            Hole17Strokes = hole17Strokes;
            Hole18Strokes = hole18Strokes;
            TotalStrokes = hole1Strokes + hole2Strokes + hole3Strokes + hole4Strokes + hole5Strokes + hole6Strokes + hole7Strokes + hole8Strokes + hole9Strokes + hole10Strokes
                + hole11Strokes + hole12Strokes + hole13Strokes + hole14Strokes + hole15Strokes + hole16Strokes + hole17Strokes + hole18Strokes;
        }
    }
}
