using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial15Dey
{
    class Patient
    {
        private int stayDays = 0;
        private int bill = 0;

        public int Bill {
            get { return bill; }
            
        }

        private void CalculateBill()
        {
            bill = 200 * StayDays;
        }


        public int StayDays
        {
            get { return stayDays; }
            set {
                stayDays = value;
                CalculateBill();
            }
        }
    }
}
