using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using InovaX.Core.DomainObjects;

namespace InovaX.Domain.Entites
{
    public class Person : Entity
    {
        protected Person() { }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public Guid AddressId { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Password { get; private set; }
        public string CPF { get; private set; }
        public Address Address { get; private set; }
    }
}
