using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step4Prototype
{
    public class User
    {
        // the fields of the User class
        private String userName;
        private String passWord;
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String province;
        private String postalCode;
        private String homePhone;
        private String cellPhone;
        private String sin;
        private DateTime dateOfBirth;
        private String region;

        // the constructor of the User class
        public User()
        {
        }

        // the properties of the User class
        public String Username
        {
            get { return userName; }
            set {
                if (value.Length <= 50)
                    userName = value;
            }
        }
        public String Password
        {
            get { return passWord; }
            set
            {
                if (value.Length <= 50)
                    passWord = value;
            }
        }
        public String Firstname
        {
            get { return firstName; }
            set
            {
                if (value.Length <= 50)
                    firstName = value;
            }
        }
        public String Lastname
        {
            get { return lastName; }
            set
            {
                if (value.Length <= 50)
                    lastName = value;
            }
        }
        public String Address
        {
            get { return address; }
            set
            {
                if (value.Length <= 50)
                    address = value;
            }
        }
        public String City
        {
            get { return city; }
            set
            {
                if (value.Length <= 50)
                    city = value;
            }
        }
        public String Province
        {
            get { return province; }
            set
            {
                if (value.Length == 2)
                    province = value;
            }
        }
        public String Postalcode
        {
            get { return postalCode; }
            set
            {
                if (value.Length == 6)
                    postalCode = value;
            }
        }
        public String Homephone
        {
            get { return homePhone; }
            set
            {
                if (value.Length <= 10)
                    homePhone = value;
            }
        }
        public String Cellphone
        {
            get { return cellPhone; }
            set
            {
                if (value.Length <= 10)
                    cellPhone = value;
            }
        }
        public String SIN
        {
            get { return sin; }
            set
            {
                if (value.Length == 9)
                    sin = value;
            }
        }
        public DateTime DOB
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public String Region
        {
            get { return region; }
            set
            {
                if (value.Length <= 2)
                    region = value;
            }
        }
    }
}
