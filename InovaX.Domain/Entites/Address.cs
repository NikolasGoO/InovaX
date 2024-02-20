using InovaX.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaX.Domain.Entites
{
    public class Address : Entity
    {
        public Address(string street, string neighborhood, string postalCode, string city, string country, string number)
        {
            Street = street;
            Neighborhood = neighborhood;
            PostalCode = postalCode;
            City = city;
            Country = country;
            Number = number;
        }

        protected Address() { }
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Number { get; private set; }
    }
}
