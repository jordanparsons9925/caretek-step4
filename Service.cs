using System;

namespace Step4Prototype
{
    class Service
    {
        string[] services = { "Personal Care", "Light Housekeeping", "Social Interaction", "Respite" };

        public string getService(int i)
        {
            return services[i];
        }
    }
}
