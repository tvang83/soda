using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        string selectedSoda;

        double machineCoins;
        int machineCans;

        List<string> sodas = new List<string>() { "Grape, Orange, Lemon"};

        //constructor 

        public SodaMachine()
        {
         List<Coin> coins = new List<Coin>();


        }


        //methods 
        //public void SelectedSoda(string value)
        //{
        //    if (selectedSoda )
        //}

        public double PaymentForSoda()
        {

            if (sodaCost == sodaValue)
            {
                Console.WriteLine("Enjoy your drink!");
                DispenseSoda();
            }
            else if (sodaCost > sodaValue)
            {
                sodaChange = sodaValue - sodaCost;
                DispenseSoda(sodaChange);
                Console.WriteLine("Here is your change and enjoy your soda.");
                return sodaChange;
            }
            else if (sodaCost < sodaValue)
            {
                sodaChange = sodaCost - sodaValue;
                Console.WriteLine("Please enter the correct change");
                return sodaChange;
            }
        }

        public void ChangeFromRegister()
        {


        }

        public string DispenseSoda(double value)
        {
            if (value == .6)
            {
                return sodas[0];                
            }
            else if (value == .35)
            {
                return sodas[1];
            }
            else if (value == .06)
            {
                return sodas[2];
            }
        }
    }
}
