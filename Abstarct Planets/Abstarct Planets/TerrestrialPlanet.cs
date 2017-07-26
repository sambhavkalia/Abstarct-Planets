using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sambhav Kalia
 * Date: July 25, 2017
 * Description: This is the sub-class TerrestrialPlanet of class Planet
 * Version: 0.1 
 */

namespace Abstarct_Planets
{
    class TerrestrialPlanet: Planet
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        // PUBLIC PROPERTIES
        public bool HasMoons()
        {
            bool moon;
            if (MoonCount > 0)
            {
                moon = true;
            }
            else
            {
                moon = false;
            }
            return moon;
        }
        public bool Habitable()
        {
            bool oxygen;
            if (oxygen = true)
            {
                return oxygen;
            }
            return oxygen;
        }
        
        // CONSTRUCTORS
        public TerrestrialPlanet(string name, double diameter, double mass) : base(name, diameter, mass)
        {
            this._oxygen = _oxygen;
        }

    }
}