using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //driver class for program, which creats a new object and  call its ToString() method
            GiantPlanet giantPlanet = new GiantPlanet("Venus",12104,0.815,"Co2");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WaitForAnyKey();

        }
        //This method reads the console for any keypress before the console is closed
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
}
}
