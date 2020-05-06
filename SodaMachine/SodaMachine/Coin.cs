using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Coin
    {
        //member variables
        public double penny;
        public double dime;
        public double nickel;
        public double quarter;


        //constructor 

        public Coin(double value)
        {
            penny = .01;
            nickel = .05;
            dime = .10;
            quarter = .25;
        }

        //methods 
        public double Penny()
        {
            return penny;
        }

        public double Nickel()
        {
            return nickel;
        }

        public double Dime()
        {
            return dime;
        }
        public double Quarter()
        {
            return quarter;
        }
    }
}
