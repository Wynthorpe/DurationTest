using System;
using System.Collections.Generic;

namespace DurationTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string startTime = "08:00 PM";
            string endTime = "10:00 AM";
            string now = DateTime.Now.ToShortDateString();
            TimeSpan duration;

            if (DateTime.Parse(startTime) > DateTime.Parse(endTime))
            {
                DateTime newStart = DateTime.Parse(now + " " + startTime);
                DateTime newEnd = DateTime.Parse(now + " " + endTime).AddDays(1);
                duration = (newStart - newEnd);
            }
            else
            {
                DateTime newStart = DateTime.Parse(startTime);
                DateTime newEnd = DateTime.Parse(endTime);
                duration = (newStart - newEnd);
            }

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(Math.Abs(duration.TotalHours));
            Console.ReadLine();
        }
    }
}