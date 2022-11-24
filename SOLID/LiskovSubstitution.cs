using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class Patient
    {
        public abstract string Admit();
    }
    public class InPatient : Patient
    {
        public override string Admit()
        {
            return "Yes";
        }
    }
    public class OutPatient : Patient
    {
        public override string Admit()  
        {
            return "No";
        }
    }
}

