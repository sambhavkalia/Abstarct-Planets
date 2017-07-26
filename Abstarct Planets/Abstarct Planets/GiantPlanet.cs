using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sambhav Kalia
 * Date: July 25, 2017
 * Description: This is the sub-class GiantPlanet of class Planet
 * Version: 0.1 
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
            public bool HasRings()
        {
            bool ring;
            if (RingCount>0)
            {
                ring = true;
            }
            else
            {
                ring = false;
            }
            return ring;
        }

        // CONSTRUCTORS
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;

        }
        // PRIVATE METHODS

    }
}