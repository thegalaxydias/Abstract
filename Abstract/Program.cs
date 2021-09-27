using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            var user = new List<IUsers>
            {
                new RegularUser { Name = "carl", Balance = 99 },
                new PremiumUser { Name = "tom", Balance = 5, BonusBalance = 3 },
                new RegularUser { Name = "jerry", Balance = 105 },
                new PremiumUser { Name = "larry", Balance = 98, BonusBalance = 1 }
            };


            ResetBalance(user);
            ShowUserBalance(user);
            


            static void ShowUserBalance(IEnumerable<IUsers> user)
            {
                foreach (IUsers users in user)
                {
                    Console.WriteLine(users.Name + users.GetBalanceData());
                }

               
            }

            static void ResetBalance(IEnumerable<IUsers> user)
            {
                foreach (IUsers users in user)
                {

                    users.Balance = 0;
                }
            }
        }
    }

}
