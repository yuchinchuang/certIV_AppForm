using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.ExceptionFolder;
using System.Text.RegularExpressions;

namespace ETS
{
    public class Validation
    {
        public void InputEmpty(string text)
        {
            if (text.Length <= 0)
                throw new EmptyInputException();
        }

        public void InputWhiteSpace(string text)
        {
            foreach (char c in text)
            {
                if (c == ' ')
                    throw new WhiteSpaceException();
            }
        }

        public void ValidateName(string name)
        {
            InputEmpty(name);
            if (name.Length > 50)
                throw new TextMaxLengthException();
            InputWhiteSpace(name);

        }

        public void ValidateEmail(string email)
        {
            InputEmpty(email);
            if (email.Length > 50)
                throw new TextMaxLengthException();
            InputWhiteSpace(email);
            if (!Regex.IsMatch(email, @"\w+@\w+\.\w+"))
                throw new InvalidEmaiException();
        }

        public void ValidateDate(DateTime date)
        {
            InputEmpty(date.ToShortDateString());
            InputWhiteSpace(date.ToShortDateString());
            if (date > DateTime.Today)
                throw new FutureException();
        }

        public void ValidatePhone(string phone)
        {
            InputEmpty(phone);
            InputWhiteSpace(phone);
            if (!Regex.IsMatch(phone, @"^\d{8,15}$"))
                throw new InvalidPhoneNumberException();
        }

        public void ValidateHour(double hour)
        {
            InputEmpty(hour.ToString());
            if (hour <= 0)
                throw new NoWorkHourException();
            if (hour > 24)
                throw new MaxDailyWorkException();
        }

    }
}
