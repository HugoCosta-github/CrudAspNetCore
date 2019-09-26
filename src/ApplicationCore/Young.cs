using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.src.ApplicationCore
{
    public class Young
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public Telephone Telephone { get; set; }
        public string Nickname { get; set; }
        public Gender Gender { get; set; }
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

        public Young()
        {
        }

        public Young(int id, string name, DateTime dateOfBirth, Address address, Telephone telephone, string nickname, 
            Gender gender, string nameFather, string nomeMother, string occupation, string churchFunction, 
            string localityEJC, DateTime dateEJC, string parish, bool baptism, bool eucharist, bool chrism)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            Telephone = telephone;
            Nickname = nickname;
            Gender = gender;
            NameFather = nameFather;
            NomeMother = nomeMother;
            Occupation = occupation;
            ChurchFunction = churchFunction;
            LocalityEJC = localityEJC;
            DateEJC = dateEJC;
            Parish = parish;
            Baptism = baptism;
            Eucharist = eucharist;
            Chrism = chrism;
        }
    }
}
