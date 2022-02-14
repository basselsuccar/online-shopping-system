using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1csc323.orderbase;
using project1csc323.feature;
using project1csc323.productbase;

namespace project1csc323.users
{
    public abstract class user
    {
        public string userid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public loginstatus status { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public user(string _userid,string _email, string _password,loginstatus _status,string _firstname,string _lastname,string _address)
        {
            userid = _userid;
            password = _password;
            email = _email;
            status = _status;
            firstname = _firstname;
            lastname = _lastname;
            address = _address;
        }
    }

    public enum loginstatus
    {
        online,
        offline,

    }
}
