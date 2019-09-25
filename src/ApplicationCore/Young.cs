using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.src.ApplicationCore
{
    public class Jovem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nickname { get; set; }
        public string NameFather { get; set; }
        public string NomeMother { get; set; }
        public string Occupation { get; set; }
        public string ChurchFunction { get; set; }
        public string LocalityEJC { get; set; }
        public DateTime DateEJC { get; set; }
        public string Parish { get; set; }
        public bool Baptism { get; set; }
        public bool Eucharist { get; set; }
        public bool Chrism { get; set; }



    }
}
