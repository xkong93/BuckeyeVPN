using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPN.Models
{
    public class FV_user
    {

        private int _id = 0;
        private string _email = "";
        private string _pwd = "";
        private string _name = "";

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public string pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
