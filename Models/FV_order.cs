using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VPN.Models
{
    public class FV_order
    {
        private int _id = 0;
        private int _userid = 0;
        private int _buy_type = 0;
        private DateTime _createtime = DateTime.Now;
        private string _VPNname = "";
        private string _VPNpwd = "";
        private int _status = 0;

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

        public int userid
        {
            get
            {
                return _userid;
            }

            set
            {
                _userid = value;
            }
        }

        public int buy_type
        {
            get
            {
                return _buy_type;
            }

            set
            {
                _buy_type = value;
            }
        }

        public DateTime createtime
        {
            get
            {
                return _createtime;
            }

            set
            {
                _createtime = value;
            }
        }

        public string VPNname
        {
            get
            {
                return _VPNname;
            }

            set
            {
                _VPNname = value;
            }
        }

        public string VPNpwd
        {
            get
            {
                return _VPNpwd;
            }

            set
            {
                _VPNpwd = value;
            }
        }

        public int status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
    }
}
