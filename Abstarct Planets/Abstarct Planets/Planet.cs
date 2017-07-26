using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Sambhav Kalia
 * Date: July 25, 2017
 * Description: This is the Planet Abstract Class
 * Version: 0.1 
 */

namespace Abstarct_Planets
{
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        // CONSTRUCTORS
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._mass = mass;
            this._diameter = diameter;
        }
        public override string ToString()
        {
            return this.Name +" has the diameter of " + this.Diameter + " kilometer and has mass of " + this.Mass + " tonnes.";
        }
        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}