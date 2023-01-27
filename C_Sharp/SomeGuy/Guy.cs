using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGuy
{
    class Guy
    {
        string name;
        int cash;

        public Guy(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
        }

        public void WriteMyInfo()
        {
            Console.WriteLine("Name: " + name+ "\nCash: " +cash+"\n");
        }
        public int GiveCash(int amount)
        {
            if(amount <= 0) {
                Console.WriteLine("Invalid Amount!\n");
                return 0;
            }
            else if(amount > cash)
            {
                Console.WriteLine(name + " doesnt have that amount availble\n");
                return 0;
            }
            else
            {
                this.cash -= amount;
                return amount;
            }
        }
        public void ReciveCash(int amount)
        {
            if (amount <= 0)
            {
                this.cash += amount;
            } 
            else
            {
                this.cash += amount;
            }
        }
        public void ToString()
        {
            Console.WriteLine(name + " Amount: " + cash);
        }
    }
}
