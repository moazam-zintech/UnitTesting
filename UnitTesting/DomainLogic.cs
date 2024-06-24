using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class DomainLogic
    {
        public string ReturnZero(int str)
        {
            if (str == 0)
            {

                return "hi successfull";
            }
            else
            {
                return "number is not zero";
            }
        }

        public DateTime ReturnDate()
        {
            return DateTime.Now;
        }
    }
}
