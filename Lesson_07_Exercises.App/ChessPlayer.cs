using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Exercises.App
{
    public class ChessPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int AgeInYears { get; set; }
        public int EloRating { get; set; }
        public TimeSpan ThisYearTrainingTime { get; set; }
        public Country Country { get; set; }

    }
}
