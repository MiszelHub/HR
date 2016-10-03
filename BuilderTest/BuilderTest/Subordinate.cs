using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderTest
{
    public abstract class Subordinate : Employee
    {

        public Job Job
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }

}