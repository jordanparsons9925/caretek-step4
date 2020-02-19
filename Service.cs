using System;

namespace Step4Prototype
{
    class Service
    {
        string[] services = { "Personal Care", "Light Housekeeping", "Social Interaction", "Respite" };

        public string getService(string serviceCode)
        {
            switch (serviceCode)
            {
                case "PC":
                    serviceName = "Personal Care";
                    break;
                case "LH":
                    serviceName = "Light Housekeeping";
                    break;
                case "SI":
                    serviceName = "Social Interaction";
                    break;
                case "R":
                    serviceName = "Respite";
                    break;
            }
            return serviceName;
        }
    }
}
