using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    public interface IDirectDepositable : IPayable
    {
        //From inheritance, we get "GetNameForPaycheck() and GetPaycheckAmount()'

        string GetBankingInfo();
    }
}
