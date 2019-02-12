using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your next birthdate as mm/dd/yyyy");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());

            string nextBirthdateDay = NextBirthdayDay(birthdate);

            Console.WriteLine($"Your birthday next year is on {nextBirthdateDay}");

            Console.ReadLine();
        }

        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
        /// <summary>
        /// Finds the day of the week of the date one year from now
        /// </summary>
        /// <param name="birthdate"></param>
        /// <returns>day of the week</returns>
        public static string NextBirthdayDay(DateTime birthdate)
        {
            birthdate = birthdate.AddYears(1);

            string dayOfWeek = birthdate.DayOfWeek.ToString();

            return dayOfWeek;
        }
    }
}
