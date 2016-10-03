using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public abstract class Supervisor : Employee, IManager
    {
        protected List<Subordinate> employees;

        public abstract List<EmployeeStatus> CheckAllSubordinateStatus();
    }
     
}