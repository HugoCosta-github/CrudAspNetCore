using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.src.ApplicationCore
{
    public class YoungSpy : Young
    {
        public string Locality { get; set; }
        public string Year { get; set; }

        public YoungSpy()
        {
        }


    }
}
