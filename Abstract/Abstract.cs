using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    abstract class IUsers
    {
      public  abstract int Balance { get; set; }
      public abstract string Name { get; set; }
      public abstract string GetBalanceData();
       public void ResetBalance()
        {
            Balance = 0;
            
        }
    }
}
