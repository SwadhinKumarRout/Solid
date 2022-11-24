using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalService patientdetail = new HospitalService();
            PaymentService paymentservice = new PaymentService();
            Invoice invoice = new Invoice();
            Mail mail = new Mail();
            patientdetail.PatientDetail("Swadhin");
            paymentservice.MakePayment("Done");
            invoice.GenerateInvoice("AIIMS101");
            mail.EmailInvoice("Sw1234");
            Console.ReadLine();

            PatientInvoice patientinvoice = new PatientInvoice();
            PatientInvoice finalInvoice = new FinalInvoice();
            PatientInvoice proposedInvoice = new ProposedInvoice();
            PatientInvoice recurringInvoice = new RecurringInvoice();
            patientinvoice.GetInvoiceDiscount(10000);
            finalInvoice.GetInvoiceDiscount(10000);
            proposedInvoice.GetInvoiceDiscount(10000);
            recurringInvoice.GetInvoiceDiscount(10000);
            Console.ReadLine();

            Patient patient = new InPatient();
            Console.WriteLine(patient.Admit());
            patient = new OutPatient();
            Console.WriteLine(patient.Admit());
            Console.ReadLine();

            PatientCharge patientcharge = new PatientCharge();
            patientcharge.Alive("Patient got new life");
            patientcharge.Death("Patient is dead");
            Console.ReadLine();

        }
    }
}
