using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iara3.Models
{
    public class Users
    {
        public String UserName;
        private int CreditCard;
        private int IdentVV;

        public Users(string _UserName, int _CreditCard, int _IdentVV)
        {
            UserName = _UserName;
            CreditCard = _CreditCard;
            IdentVV = _IdentVV;

            //Console.WriteLine("User created: " + UserName);
        }


    }
}
