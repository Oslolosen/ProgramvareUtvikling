using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoe
{
    class MenuItem
    {
        public Random random = new Random();
        public string[] meat = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] sauce = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] bread = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string description = "";
        public string price;


        public void generate()
        {
            this.price = "";
            this.description = "";


            description += meat[random.Next(meat.Length)];
            description += " "+sauce[random.Next(sauce.Length)];
            description += " "+bread[random.Next(bread.Length)];

            decimal price = random.Next(2, 5) + random.Next(1, 98);
            this.price = price.ToString("C");
        }

        public string toString()
        {
            return "Todays menu: "+description+"\nPrice :" + price;
        }
    }
}
