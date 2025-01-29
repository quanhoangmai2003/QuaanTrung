using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class USERS
    {
        QLNHANSUEntities db;
        public USERS()
        {
            db = new QLNHANSUEntities();
        }
        public int Login(string username, string pass)
        {
            var us = db.tb_USER.FirstOrDefault(x=>x.USERNAME == username && x.PASS==pass);
            if (us != null)
                return 1;
            else
                return 0;
        }
    }
}
