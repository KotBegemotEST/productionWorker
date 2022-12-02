using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionWorker
{
    public class ProductionWorker : Employee
    {
        public ProductionWorker(string name, int id, int shift, decimal hourlyPay) : base(name, id) {

            ShiftNumber = shift ;
            HourlyPay = hourlyPay;

        }

        public int ShiftNumber { get; set; }
        public decimal HourlyPay { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                "worker shift: " + ShiftNumber + "\r\n" +
                "worker hourly pay: " + HourlyPay + "\r\n";
                ;
        }
    }
}
