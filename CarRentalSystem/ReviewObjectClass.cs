using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    //Created by Sayali S. Bujade
    public class ReviewObjectClass
    {
        private string _username;
        private string _desc;
        public ReviewObjectClass(string username, string desc)
        {
            _username = username;
            _desc = desc;
        }//ctor

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }//class
}//namespace
