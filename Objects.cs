﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step4Prototype
{
    class Objects
    {
        public static PCA[] PCAobjects()
        {

            //Making PCAs
            PCA pca1 = new PCA
            {
                userName = "abc1234",
                firstName = "Lori",
                lastName = "Payne",
                Address = "33 Broadway",
                City = "Corner Brook",
                postalCode = "a2h"
            };

            PCA pca2 = new PCA
            {
                userName = "bcd1234",
                firstName = "Lori",
                lastName = "Payne",
                Address = "20 Broadway",
                City = "Corner Brook",
                postalCode = "a2h"
            };

            PCA[] allPCA = { pca1, pca2 };
            return allPCA;
        }

    public static Shift[] shiftObjects()
        {
            //Making Shifts
            Shift shift1 = new Shift
            {
                startTime = ,
                endTime = ,
                clientProxy = ,
                employee = ,
                service = ,
                serviceDetail = 

            };

            Shift shift2 = new Shift
            {
                startTime = ,
                endTime = ,
                clientProxy = ,
                employee = ,
                service = ,
                serviceDetail =
            };

            Shift shift3 = new Shift
            {
                startTime = ,
                endTime = ,
                clientProxy = ,
                employee = ,
                service = ,
                serviceDetail =
            };

            Shift[] allShifts = {shift1, shift2, shift3}; //Make more if needed
            return allShifts;
        }
        public static ClientProxy[] clientObjects()
        {
            //Making Clients
            ClientProxy client1 = new ClientProxy
            {
                physician = ,
                residenceType = ,
                payment = ,
                proxyFirstName = ,
                proxyLastName = ,
                proxyRelationship = ,
                proxyAddress = ,
                proxyCity = ,
                proxyProvince = ,
                country = ,
                proxyHomePhone = ,
                proxyCell = ,
                service = ,
                status = ,
            };

            ClientProxy client2 = new ClientProxy
            {
                physician = ,
                residenceType = ,
                payment = ,
                proxyFirstName = ,
                proxyLastName = ,
                proxyRelationship = ,
                proxyAddress = ,
                proxyCity = ,
                proxyProvince = ,
                country = ,
                proxyHomePhone = ,
                proxyCell = ,
                service = ,
                status = ,
            };
            ClientProxy[] allClients = {client1, client2};
            return allClients;
        }
    }
}
