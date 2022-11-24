using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IPatientDataAccess
    {
        string GetPatientName(int id);
    }

    public class PatientDataAccess : IPatientDataAccess
    {
        public PatientDataAccess()    //Constructor
        {
        }

        public string GetPatientName(int id)
        {
            return "Customer Name";
        }
    }

    public class PatientDataAccessFactory
    {
        public static IPatientDataAccess GetPatientDataAccessObj()
        {
            return new PatientDataAccess();
        }
    }

    public class PatientBusinessLogic
    {
        IPatientDataAccess _patientDataAccess;

        public PatientBusinessLogic()
        {
            _patientDataAccess = PatientDataAccessFactory.GetPatientDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _patientDataAccess.GetPatientName(id);
        }
    }
}
