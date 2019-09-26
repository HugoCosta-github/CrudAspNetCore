using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.src.ApplicationCore
{
    public class Telephone
    {
        public int DDD { get; set; }
        public int NumberTelephone { get; set; }

        public Telephone()
        {
        }

        public Telephone(int dDD, int numberTelephone)
        {
            DDD = dDD;
            NumberTelephone = numberTelephone;
        }
    }
}
