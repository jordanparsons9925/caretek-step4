using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step4Prototype
{
    class Validation
    {
        //Shift Rules
        /// <summary>
        /// Making sure we're on a sweatshop
        /// </summary>
        /// <param name="shift"></param>
        /// <param name="pca"></param>
        public static void validateSchedule(Shift shift, PCA pca)
        {
            Shift[] schedule = pca.fullSchedule;
            for (int i = 0; i < pca.fullSchedule.Length; i++)
            {
                if (shift.startTime <= schedule[i].endTime && schedule[i].startTime <= shift.endTime)
                {
                    throw new Exception("PCA is already scheduled at current time.");
                }

                //Shifts be less than 12hrs in 24hr period
                if (Convert.ToInt32(shift.endTime.Subtract(shift.startTime)) >= 12 && Convert.ToInt32(schedule[i].endTime.Subtract(shift.endTime)) < 24)
                {
                    throw new Exception("Cannot make 12-hour shift. PCA is already scheduled for another shift in the 24-hour before.");
                }

                //No three consecutive 12hr shifts
                if(Convert.ToInt32(shift.endTime.Subtract(shift.startTime)) >= 12)
                {

                }

                //PCA not scheduled over 160 hours in a four-week period
            }

        }

        //Region Rules
        /// <summary>
        /// Making sure Client and PCA are in the same region
        /// </summary>
        /// <param name="pca"></param>
        /// <param name="client"></param>
        public static bool validateRegion(PCA pca, ClientProxy client)
        {
            if (pca.Region != client.Region)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Service Rules
        /// <summary>
        /// Making sure clients in group living areas don't get light housekeeping
        /// </summary>
        /// <param name="client"></param>
        public static void validateService(ClientProxy client)
        {
            if (client.ResidenceType != "group living")
            {
                if (client.Service == "light housekeeping")
                {
                    throw new Exception("Well sir it's not technically your house.");
                }
            }
        }
    }
}
