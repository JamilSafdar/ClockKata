using System;
using System.Collections.Generic;
using System.Text;

namespace ClockKata
{
    public class Validation
    {
        public bool IsHourValid(int hour)
        {
            if (hour < 0 || hour > 23)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsMinuteValid(int minute)
        {
            if (minute < 0 || minute > 59)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsSecondValid(int second)
        {
            if (second < 0 || second > 59)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
