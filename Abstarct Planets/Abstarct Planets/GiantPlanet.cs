using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sambhav Kalia
 * Date: July 25, 2017
 * Description: This is the sub-class GiantPlanet of class Planet
 * Version: 0.2 fix if loops
 */

namespace Abstarct_Planets
{
    class GiantPlanet: Planet
    {
        // PRIVATE INSTANCE VARIABLES
        private string _type;
        // PUBLIC PROPERTIES
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }
        public bool HasRings()
        {
            if (RingCount>0)
            {
                return true;
            }
                return false;
        }

        // CONSTRUCTORS
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;

        }
        // PRIVATE METHODS

    }
}