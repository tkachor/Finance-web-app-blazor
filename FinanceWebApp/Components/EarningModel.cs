using FinanceWebApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebApp.Components
{
    public class EarningModel
    {
        public DateTime Date { get; set; }

        public string Subject { get; set; }

        public EarningCategory Category { get; set; }

        public decimal Amount { get; set; }
    }
}
