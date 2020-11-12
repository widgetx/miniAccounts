using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Whatever you do.. don't stop being a developer for 18 months then expect to ramp up to where you left off without a bit of "OH **** moments"

namespace miniAccounts.Models
{
    public partial class Account
    {
        public override string ToString()
        {
            return this.AccountId;
        }
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
            var accounts = new List<Account>
            {
                new Account
                {
                    AccountId = "CH101",
                    Balance = 0,
                    Name = "Main Account",
                    Transactions = new List<Transaction>{
                        new Transaction
                        {
                            Ref = "Opening Balance",
                            AccountIdFrom = "",
                            AccountIdTo ="CH101",
                            Credit = 101.01M,
                            BookedOn = DateTime.Now
                        },
                        new Transaction
                        {
                            Ref="T101",
                            AccountIdFrom = "CH102",
                            AccountIdTo ="CH101",
                            Debit = 100,
                            BookedOn = DateTime.Now
                        }
                    },
                    Unit = "CHF"
                },
                new Account
                {
                    AccountId = "CH102",
                    Balance = 0,
                    Name = "Other Account",
                    Transactions = new List<Transaction>{
                        new Transaction
                        {
                            Ref="T101",
                            AccountIdFrom = "CH101",
                            AccountIdTo ="CH102",
                            Credit = 100,
                            BookedOn = DateTime.Now
                        }
                    },
                    Unit = "CHF"
                }
            };

            // bit of fiddling with the calcs until get booking engine implmented
            foreach(var a in accounts)
            {
                a.Balance = a.Transactions.Sum(t => t.Credit - t.Debit);
            }
            return accounts;
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
