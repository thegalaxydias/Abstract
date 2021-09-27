using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class RegularUser : IUsers
    {
        public override int Balance { get; set; }
        public override string Name { get; set; } 
        public override string GetBalanceData()
        {
            return $"`s balance is: {Balance}";
        }
        
    }
}
