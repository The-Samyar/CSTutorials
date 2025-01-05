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
        private const int PricePerDay =200;

        public int Bill {
            get { return bill; }
            
        }

        private void CalculateBill()
        {
            bill = PricePerDay * StayDays;
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
