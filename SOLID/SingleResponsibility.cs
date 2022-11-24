using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class HospitalService
    {
        public string PatientDetail(string PatientName)  //method which return patient Name
        {
            Console.WriteLine("Patient Name is" + " " + PatientName);
            return PatientName;
        }
    }
    public class PaymentService {
        public bool MakePayment(string Status)    //method which return status of Payment
        {
            Console.WriteLine("Payment Status is" + " " + Status);
            return true;
        }
    }
    public class Invoice { 
        public bool GenerateInvoice(string OrderId)    //method which return patient Payment InvoiceId
        {
            Console.WriteLine("InvoiceId is" + " " + OrderId);
            return true;
        }
    }
    public class Mail { 

        public bool EmailInvoice(string OrderId)    //method which return patient mail InvoiceId
        {
            Console.WriteLine("EmailId is" + " " + OrderId);
            return true;
        }
    }
}
