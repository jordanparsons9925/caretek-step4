﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step4Prototype
{
    public class ClientProxy : User
    {
        // the fields of the Client/Proxy class
        private String physician;
        private String residenceType;
        private String payment;
        private String proxyName;
        private String proxyRelationship;
        private String proxyAddress;
        private String proxyCity;
        private String proxyProvince;
        private String country;
        private String proxyHomePhone;
        private String proxyCell;
        private String service;
        private String status;

        // the constructor of the Client/Proxy class
        public ClientProxy() : base()
        {
        }

        // the properties of the User class
        public String Physician
        {
            get { return physician; }
            set
            {
                if (value.Length <= 50)
                    physician = value;
            }
        }
        public String ResidenceType
        {
            get { return residenceType; }
            set
            {
                if (value.Length <= 50)
                    residenceType = value;
            }
        }
        public String Payment
        {
            get { return payment; }
            set
            {
                if (value.Length <= 50)
                    payment = value;
            }
        }
        public String ProxyName
        {
            get { return proxyName; }
            set
            {
                if (value.Length <= 50)
                    proxyName = value;
            }
        }
        public String ProxyRelationship
        {
            get { return proxyRelationship; }
            set
            {
                if (value.Length <= 50)
                    proxyRelationship = value;
            }
        }
        public String ProxyAddress
        {
            get { return proxyAddress; }
            set
            {
                if (value.Length <= 50)
                    proxyAddress = value;
            }
        }
        public String ProxyCity
        {
            get { return proxyCity; }
            set
            {
                if (value.Length <= 20)
                    proxyCity = value;
            }
        }
        public String ProxyProvince
        {
            get { return proxyProvince; }
            set
            {
                if (value.Length == 2)
                    proxyProvince = value;
            }
        }
        public String Country
        {
            get { return country; }
            set
            {
                if (value.Length <= 10)
                    country = value;
            }
        }
        public String ProxyHomePhone
        {
            get { return proxyHomePhone; }
            set
            {
                if (value.Length <= 10)
                    proxyHomePhone = value;
            }
        }
        public String ProxyCell
        {
            get { return proxyCell; }
            set
            {
                if (value.Length <= 10)
                    proxyCell = value;
            }
        }
        public String Service
        {
            get { return service; }
            set
            {
                if (value.Length <= 20)
                    service = value;
            }
        }
        public String Status
        {
            get { return status; }
            set
            {
                if (value.Length <= 10)
                    status = value;
            }
        }

        // the methods of the Client/Proxy class
        public void requestService(String service)
        {
            throw new System.NotImplementedException();
        }
        public void changeService()
        {
            throw new System.NotImplementedException();
        }
        public void changeInformation()
        {
            throw new System.NotImplementedException();
        }
        public void giveFeedback(String feedback)
        {
            throw new System.NotImplementedException();
        }
    }
}
