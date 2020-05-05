using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables
        double sodaValue;
        double sodaChange;
        double sodaCost;
        List<string> sodas = new List<string>() { "Grape, Orange, Lemon"};
        List<Coins> coins = new List<Coins>() { };

        //constructor 

        public SodaMachine()
        {
            

        }

        
        //methods 

        public void PaymentForSoda()
        {

            if (sodaCost == sodaValue)
            {
                Console.WriteLine("Enjoy your drink!");
                DispenseSoda();
            }
            else
            {
                Console.WriteLine("Please enter the correct change");
                sodaCost = 0;
            }
        }

        public void ChangeFromRegister()
        {

        }

        public void DispenseSoda()
        {

        }
    }
}
