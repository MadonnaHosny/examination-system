using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationSystem.Entities
{
    public partial class Person
    {
        public string FullName
        {
            get
            {
                return Fname + " " + Lname;
            }
        }
    }
}
