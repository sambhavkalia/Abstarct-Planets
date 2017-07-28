using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Github: https://github.com/sambhavkalia/Abstarct-Planets 
 * Name: Sambhav Kalia
 * Student ID: 300900171
 * Date: July 25, 2017
 * Description: This is the Main Program
 * Version: 0.2 Added more planets and Switch Statement to select planets.
 */

namespace Abstarct_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("=============Sambhav Kalia’s Assignment 4=================");
            Console.WriteLine("|                    1. Mercury                          |");
            Console.WriteLine("|                    2. Venus                            |");
            Console.WriteLine("|                    3. Earh                             |");
            Console.WriteLine("|                    4. Mars                             |");
            Console.WriteLine("|                    5. Jupiter                          |");
            Console.WriteLine("|                    6. Saturn                           |");
            Console.WriteLine("|                    7. Uranus                           |");
            Console.WriteLine("|                    8. Neptune                          |");
            Console.WriteLine("|                    0. End program                      |");
            Console.WriteLine("|                                                        |");
            Console.WriteLine("|               Know About The Planets                   |");
            Console.WriteLine("==========================================================");
            Console.Write(" Enter the number to select Planet -> ");
        }
        static void ShowMenu()
        {
            //driver class for program, which creats a new object and  call its ToString() method
            string caseSwitch;
            do
            {
                DisplayMenu();
                caseSwitch = Console.ReadLine();
                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("\n---------Knowlegde of Mercury----------");
                        TerrestrialPlanet Mercury = new TerrestrialPlanet("Mercury", 4879, 3.302, false);
                        Mercury.ToString();
                        Console.Write("Mercury has one or more moons : ");
                        int moon1 = 0;
                        Mercury.MoonCount = moon1;
                        Console.WriteLine(Mercury.HasMoons());
                        Console.Write("Mercury has oxygen to live : ");
                        Console.Write(Mercury.Habitable());
                        WaitForAnyKey();
                        break;
                    case "2":
                        Console.WriteLine("\n---------Knowlegde of Venus----------");
                        TerrestrialPlanet Venus = new TerrestrialPlanet("Venus", 12104, 4.867, false);
                        Venus.ToString();
                        int moon2 = 0;
                        Venus.MoonCount = moon2;
                        Console.Write("Venus has one or more moons : ");
                        Console.WriteLine(Venus.HasMoons());
                        Console.Write("Venus has oxygen to live : ");
                        Console.WriteLine(Venus.Habitable());
                        WaitForAnyKey();
                        break;
                    case "3":
                        Console.WriteLine("\n---------Knowlegde of Earth----------");
                        TerrestrialPlanet Earth = new TerrestrialPlanet("Earth", 12742, 5.972, true);
                        Earth.ToString();
                        Console.Write("Earth has one moon : ");
                        int moon3 = 1;
                        Earth.MoonCount = moon3;
                        Console.WriteLine(Earth.HasMoons());
                        Console.Write("Earth has oxygen to live : ");
                        Console.WriteLine(Earth.Habitable());
                        WaitForAnyKey();
                        break;
                    case "4":
                        Console.WriteLine("\n---------Knowlegde of Mars----------");
                        TerrestrialPlanet Mars = new TerrestrialPlanet("Mars", 6779, 6.418, false);
                        Mars.ToString();
                        Console.Write("Mars has two moons :");
                        int moon4 = 2;
                        Mars.MoonCount = moon4;
                        Console.WriteLine(Mars.HasMoons());
                        Console.Write("Mars has oxygen to live : ");
                        Console.WriteLine(Mars.Habitable());
                        WaitForAnyKey();
                        break;
                    case "5":
                        Console.WriteLine("\n---------Knowlegde of Jupiter----------");
                        GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139822, 1.8986000, "Ice");
                        Jupiter.ToString();
                        Console.Write("Jupiter has 67 moons : ");
                        int moon5 = 67;
                        Jupiter.MoonCount = moon5;
                        Console.WriteLine(Jupiter.HasMoons());
                        Console.Write("Jupiter has four rings : ");
                        int ring5 = 4;
                        Jupiter.RingCount = ring5;
                        Console.WriteLine(Jupiter.HasRings());
                        WaitForAnyKey();
                        break;
                    case "6":
                        Console.WriteLine("\n---------Knowlegde of Saturn----------");
                        GiantPlanet Saturn = new GiantPlanet("Saturn", 116464, 5.684600, "Ice");
                        Saturn.ToString();
                        Console.Write("Saturn has 62 moons :");
                        int moon6 = 62;
                        Saturn.MoonCount = moon6;
                        Console.WriteLine(Saturn.HasMoons());
                        Console.Write("Saturn has seven rings : ");
                        int ring6 = 7;
                        Saturn.RingCount = ring6;
                        Console.WriteLine(Saturn.HasRings());
                        Saturn.ToString();
                        WaitForAnyKey();
                        break;
                    case "7":
                        Console.WriteLine("\n---------Knowlegde of Uranus----------");
                        GiantPlanet Uranus = new GiantPlanet("Uranus", 50724, 8.68100, "Gas");
                        Uranus.ToString();
                        Console.Write("Uranus has 27 moons :");
                        int moon7 = 27;
                        Uranus.MoonCount = moon7;
                        Console.WriteLine(Uranus.HasMoons());
                        Console.Write("Uranus has 13 rings : ");
                        int ring7 = 13;
                        Uranus.MoonCount = ring7;
                        Console.WriteLine(Uranus.HasRings());
                        WaitForAnyKey();
                        break;
                    case "8":
                        Console.WriteLine("\n---------Knowlegde of Neptune----------");
                        GiantPlanet Neptune = new GiantPlanet("Neptune", 49244, 10.2430, "Gas");
                        Neptune.ToString();
                        Console.Write("Neptune has 14 moons :");
                        int moon8 = 14;
                        Neptune.MoonCount = moon8;
                        Console.WriteLine(Neptune.HasMoons());
                        Console.Write("Neptune has 5 rings : ");
                        int ring8 = 5;
                        Neptune.MoonCount = ring8;
                        Console.WriteLine(Neptune.HasMoons());
                        WaitForAnyKey();
                        break;
                }
            }
            while (caseSwitch != "0");
        }
        //This method reads the console for any keypress before the console is closed
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}

