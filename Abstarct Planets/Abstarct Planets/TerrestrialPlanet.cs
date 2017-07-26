using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sambhav Kalia
 * Date: July 25, 2017
 * Description: This is the sub-class TerrestrialPlanet of class Planet
 * Version: 0.2 
 */

namespace Abstarct_Planets
{
    class TerrestrialPlanet: Planet,IHasMoons,IHabitable
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        // PUBLIC PROPERTIES
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
                return false;
        }
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            return false;
        }

        // CONSTRUCTORS
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            oxygen = this._oxygen;
        }

    }
}