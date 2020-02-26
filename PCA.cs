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
            throw new System.NotImplementedException();
        }
        public Shift[] viewSchedule()
        {
            return fullSchedule;
        }
    }
}