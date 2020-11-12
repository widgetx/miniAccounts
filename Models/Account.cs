using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniAccounts.Models
{
    public partial class Account
    {
        public string AccountId { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Balance{ get; set; } = 0;
        public string Unit { get; set; } = "";

        public List<Transaction> Transactions { get; set; } 
    }

    public partial class Account //: ÎTestData
    {
        public static List<Account> InMemoryTestData()
        {
            return new List<Account>
            {
                new Account
                {
                    AccountId = "CH101",
                    Balance = 0,
                    Name = "Main Account",
                    Transactions = new List<Transaction>(),
                    Unit = "CHF"
                },
                new Account
                {
                    AccountId = "CH102",
                    Balance = 0,
                    Name = "Other Account",
                    Transactions = new List<Transaction>(),
                    Unit = "CHF"
                }
            };
        }
    }

    //public partial class Account : ÎTestData
    //{
    //    List<object> ÎTestData.InMemoryTestData()
    //    {
    //        return new List<Account>
    //        {
    //            new Account
    //            {

    //            }
    //        }.ToArray();
    //    }
    //}

    //public interface ÎTestData
    //{
    //    List<object> InMemoryTestData();
    //}
}
