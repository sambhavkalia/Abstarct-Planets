using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Github: https://github.com/sambhavkalia/Abstarct-Planets 
 * Name: Sambhav Kalia
 * Student ID: 300900171
 * Date: July 25, 2017
 * Description: This is the Planet Abstract Class
 * Version: 0.3 - updated output structure
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
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
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
                return _name;
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
            string pInfo = "Planet =" + this.Name + " \nDiameter =" + this.Diameter + " kilometer \nMass =" + this.Mass + " x 10^24 kilograms.";
            Console.WriteLine(pInfo);
            return pInfo;
        }
        // PRIVATE METHODS

        // PUBLIC METHODS

    }
}