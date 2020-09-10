using System;

namespace ClockKata
{
    public class Clock
    {
        public static int ConvertTimehmsToMillseconds(int hour, int minute, int second)
        {
            var output = 0;

            if (new Validation().IsHourValid(hour))
            {
                output = hour * 3600000;
                output += minute * 60000;
                output += second * 1000;

                return output;
            }
            else
            {
                return output;
            }
        }
    } 
}