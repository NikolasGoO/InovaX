using InovaX.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaX.Domain.Entites
{
    public class Questionary : Entity
    {
        protected Questionary() { }
        public bool HasCompany { get; private set; }
        public string Objective { get; private set; }
        public string Caracteristic { get; private set; }
        public bool IsAproved { get; private set; }
        public string TargetAudience { get; private set; }
        public Employe Employe { get; private set; }
        public Guid EmployeId { get; private set; }
        public string Integrations { get; private set; }
    }
}
