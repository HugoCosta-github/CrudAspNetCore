using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.src.ApplicationCore
{
    public class Address
    {
        public string Place { get; set; }
        public int AddressNumber { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public int ZipCode { get; set; }

        public Address()
        {
        }



    }
}
