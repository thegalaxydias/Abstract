using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PremiumUser : IUsers
    {
        public override int Balance { get; set; }
        public int BonusBalance { get; set; }
        public override string Name { get; set; }
        public override string GetBalanceData()
        {
            return $"`s balance is: {Balance} + {BonusBalance}. Attention! This is Premium user."
;
        }



    }
}
