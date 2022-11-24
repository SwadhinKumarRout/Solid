using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IPatientStatus
    {
        void Alive(string AliveCertificate);
        void Death(string DeathCertificate);
    }
    interface IOpeartion
    {
        void Success(string Alive);
    }
    interface IMedicine
    {
        void Medicne(string Good);
    }
    public class HealthCondition : IPatientStatus, IOpeartion,
                                    IMedicine
    {
        public void Alive(string AliveCertificate)
        {
            Console.WriteLine("Patient is well");
        }
        public void Death(string DeathCertificate)
        {
            Console.WriteLine("Patient is no more");
        }
        public void Success(string Alive)
        {
            Console.WriteLine("Patient is Out of Danger");
        }
        public void Medicne(string Good)
        {
            Console.WriteLine("Medicine is working");
        }
    }
    class PatientCharge : IPatientStatus
    {
        public void Alive(string AliveCertificate)
        {
            Console.WriteLine("Patient is well");
        }
        public void Death(string DeathCertificate)
        {
            Console.WriteLine("Patient is no more");
        }
    }
}

