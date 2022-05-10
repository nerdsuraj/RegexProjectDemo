using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProject
{
     class Patterns
    {
        public static string REG_PINCODE = "^[1-9][0-9]{5}$";
        public static string REG_EMAIL = "^[a-zA-Z0-9_/-/.]+[@][a-z]+[/.][a-z]{2}[/.][a-z]{2,3}$";

        //"^[a-zA-Z0-9_/-/.]+[@][a-z]+[/.][a-z]{2,3}$";                       //adhau.parag64@gmail.com
        //[a-zA-Z0-9_/-/.]+[@][a-z]+[/.][a-z]{2}[/.][a-z]{2,3}$                //adhau.parag64@gmail.co.in

        public static string REG_PHONENUM = "^[/+91]*[ ]*[/-]*[0-9]{10}$";            //[6-9]{1}[0-9]{9}

        public static string REG_PASSWORD = "^([A-Z]{1,})([/_/*/&/$/@])*[a-zA-Z0-9]{6,}$";


        public bool ValidatePinCode(String pincode)
        {
            return Regex.IsMatch(pincode, REG_PINCODE);
           
        }
        public bool ValidateEmailID(String email)
        {
            return Regex.IsMatch(email, REG_EMAIL);
        }
        public bool ValidatePhoneNum(String phone)
        {
            return Regex.IsMatch(phone, REG_PHONENUM);
        }
        public bool ValidatePassword(String password)
        {
            return Regex.IsMatch(password, REG_PASSWORD);
        }

    }
}
