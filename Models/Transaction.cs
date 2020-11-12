using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniAccounts.Models
{
    public class Transaction
    {
        public string AccountIdFrom { get; set; } = "";
        public string AccountIdTo { get; set; } = "";
        public decimal Credit { get; set; } = 0;
        public decimal Debit { get; set; } = 0;
        public DateTime? BookedOn { get; set; }
        public DateTime? ValueOn { get; set; }
        public string Ref { get; set; } = "";
    }
}
