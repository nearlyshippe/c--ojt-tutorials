using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessTracker
{
    class mbCls
    {
        String memberID, memberName, userName, userPassword, Email;
        
        public String mbID
        {
            get { return memberID; }
            set { memberID = value; }
        }
        
        public String mbName
        {
            get { return memberName; }
            set { memberName = value; }
        }
        public String mbuserName
        {
            get { return  userName; }
            set { userName = value; }
        }
        public String mbuserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public String mbEmail
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
