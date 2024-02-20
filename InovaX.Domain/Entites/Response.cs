using InovaX.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaX.Domain.Entites
{
    public class Response : Entity
    {
        protected Response() { }

        public Guid EmployeID { get; private set; }
        public Employe Employe { get; private set; }
        public string Responsee { get; private set; }
        public bool IsAproved { get; private set; }
    }
}
