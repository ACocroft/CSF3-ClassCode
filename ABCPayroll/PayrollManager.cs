using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    public class PayrollManager //: Object
    {
        public static void ProcessPaycheck(IPayable target)
        {
            Console.WriteLine($"A paper check has been issued to {target.GetFullName()}\n" +
                $"Payment Amount: {target.GetPayCheckAmount():c}.");
        }

        public static void DoDirectDeposit(IDirectDepositable target)
        {
            Console.WriteLine($"{target.GetFullName()} was paid {target.GetPayCheckAmount():c}\n" +
                $"The funds were transfered to {target.GetBankingInfo()}.");
        }
    }
}
