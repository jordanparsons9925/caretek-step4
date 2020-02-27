using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Step4Prototype
{
    public class PCA : User
    {
        public Shift[] fullSchedule = {};
        public PCA() : base()
        {
            
        }
        public Shift[] viewSchedule()
        {
            return fullSchedule;
        }
    }
}