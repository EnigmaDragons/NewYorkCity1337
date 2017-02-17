using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYorkCity1337.NewFolder1
{
    public class Cash
    {
        public string AmountAndCurrency { get { return "$" + amount; } }
        private int amount = 100;
        public int Amount { get { return amount; } }

        public bool EnoughMoney(int cost)
        {
            return amount >= cost;
        }

        public void Lose(int amount)
        {
            this.amount -= amount;
        }

        public void Gain(int amount)
        {
            this.amount += amount;
        }
    }
}
