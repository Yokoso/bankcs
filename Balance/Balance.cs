using System;

namespace Balance
{
    public class Balance
    {
        private decimal balance = 0;
        public decimal limit = 100;
        public decimal debet = 300;

        public decimal balanceInformation 
        { 
            get => balance;
        }

        public decimal addToBalance 
        {
            set 
            {
                if (value > 0) 
                {
                    balance += value;
                }
            }
        }

        public decimal subtractFromBalance 
        {
            set 
            {
                if(value > 0 && value <= this.limit && value <= this.balanceInformation + this.debet)
                {
                    balance -= value;
                }
                else {
                    Console.WriteLine("transaction cancelled");
                }
            }
        }
    }
}
