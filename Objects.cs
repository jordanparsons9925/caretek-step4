using System;
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
                userName = "lopay0123",
                passWord = "AcEgI135",
                province = "NL",
                homePhone = "7093880123",
                cellPhone = "7092169215",
                sin = "127000123",
                firstName = "Lori",
                lastName = "Payne",
                dateOfBirth = new DateTime(1980, 9, 24),
                address = "5 Basha Place",
                city = "Corner Brook",
                postalCode = "A2H 6T9",
                region = "WC",
            };

            PCA pca2 = new PCA
            {
                userName = "brsmi2468",
                passWord = "Passw0rd!",
                province = "NL",
                homePhone = "7096345645",
                cellPhone = "7096387943",
                sin = "127123111",
                firstName = "Brenda",
                lastName = "Smith",
                dateOfBirth = new DateTime(1972, 7, 5),
                address = "42 Maple Lane",
                city = "Corner Brook",
                postalCode = "A2H 2J7",
                region = "WC",
            };

            PCA pca3 = new PCA
            {
                userName = "demil9034",
                passWord = "D34n3579",
                province = "NL",
                homePhone = "7096348621",
                cellPhone = "7096384129",
                sin = "127049034",
                firstName = "Dean",
                lastName = "Miller",
                dateOfBirth = new DateTime(1977, 2, 10),
                address = "9 Atlantic Avenue",
                city = "Corner Brook",
                postalCode = "A2H 1S4",
                region = "WC",
            };

            PCA pca4 = new PCA
            {
                userName = "hejon4765",
                passWord = "rehtaeH4?",
                province = "NL",
                homePhone = "7096345645",
                cellPhone = "7096387943",
                sin = "127124765",
                firstName = "Heather",
                lastName = "Jones",
                dateOfBirth = new DateTime(1982, 3, 27),
                address = "342 2nd Avenue",
                city = "Corner Brook",
                postalCode = "A2H 5Z2",
                region = "WC",
            };

            PCA[] allPCA = { pca1, pca2, pca3, pca4 };
            return allPCA;
        }

        public static ClientProxy[] clientObjects()
        {
            //Making Clients
            ClientProxy client1 = new ClientProxy
            {
                userName = "dohew4685",
                passWord = "Dotty123",
                physician = "Dr. Jones",
                firstName = "Dorothy",
                lastName = "Hewlin",
                address = "32 Riverhead Road",
                city = "Corner Brook",
                province = "NL",
                postalCode = "A2A 1J4",
                homePhone= "7096371685",
                residenceType = "Personal",
                payment = "Insurance",
                cellPhone = "7098431238",
                sin = "127234685",
                dateOfBirth = new DateTime(1949, 4, 16),
                region = "WC",
                proxyFirstName = "Sara",
                proxyLastName = "Smith",
                proxyRelationship = "Daughter",
                proxyAddress = "17 2nd Avenue",
                proxyCity = "Deer Lake",
                proxyProvince = "NL",
                country = "Canada",
                proxyHomePhone = "7096354687",
                proxyCell = "7096364532",
                service = "Personal Care",
                status = "Active", 
            };

            ClientProxy client2 = new ClientProxy
            {
                userName = "hubre8451",
                passWord = "1234abcd",
                physician = "Dr. Mayer",
                firstName = "Hubert",
                lastName = "Brennan",
                address = "7 Forest Lane",
                city = "Corner Brook",
                province = "NL",
                postalCode = "A3B 6Y2",
                homePhone = "7096345113",
                residenceType = "Personal",
                payment = "Insurance",
                cellPhone = "7098564117",
                sin = "119485237",
                dateOfBirth = new DateTime(1941, 3, 10),
                region = "WC",
                proxyFirstName = "Joe",
                proxyLastName = "Brennan",
                proxyRelationship = "Son",
                proxyAddress = "8 Maple Drive",
                proxyCity = "Stephenville",
                proxyProvince = "NL",
                country = "Canada",
                proxyHomePhone = "7096436589",
                proxyCell = "7098841168",
                service = "Personal Care",
                status = "Active",
            };

            ClientProxy[] allClients = {client1, client2};
            return allClients;
        }
    }
}
