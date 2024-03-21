using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessTracker
{
    class StaffClass
    {
        int sID;
        String staffNO, staffName, phoneNo1, phoneNo2,NRC,staffAddress, encryptedPwd, imagePath;
        Image sImage;
        DateTime staffDob, staffJoin;
        short staffType,staffGender,isDelete;
        public short IsDelete
        {
            get
            {
                return isDelete;
            }
            set
            {
                isDelete = value;
            }
        }
        public int SID
        {
            get
            {
                return sID;
            }
            set
            {
                sID = value;
            }
        }
        public String EncryptedPwd
        {
            get
            {
                return encryptedPwd;
            }
            set
            {
                encryptedPwd = value;
            }
        }
        public String ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
            }
        }
        public String StaffAddress
        {
            get
            {
                return staffAddress;
            }
            set
            {
                staffAddress = value;
            }
        }
        public String StaffNO
        {
            get
            {
                return staffNO;
            }
            set
            {
                staffNO = value;
            }
        }
        public String StaffName
        {
            get
            {
                return staffName;
            }
            set
            {
                staffName = value;
            }
        }
        public String Nrc
        {
            get
            {
                return NRC;
            }
            set
            {
                NRC = value;
            }
        }
        public Image SImage
        {
            get { return sImage; }
            set { sImage = value; }
        }
        public short StaffType
        {
            get { return staffType; }
            set { staffType = value; }

        }
        public short StaffGender
        {
            get { return staffGender; }
            set { staffGender = value; }

        }
        public DateTime StaffDob
        {
            get
            {
                return staffDob;
            }
            set
            {
                staffDob = value;
            }
        }
        public DateTime StaffJoin
        {
            get
            {
                return staffJoin;
            }
            set
            {
                staffJoin = value;
            }
        }
        public String StaffPhone1
        {
            get
            {
                return phoneNo1;
            }
            set
            {
                phoneNo1 = value;
            }
        }
        public String StaffPhone2
        {
            get
            {
                return phoneNo2;
            }
            set
            {
                phoneNo2 = value;
            }
        }
    }
}
