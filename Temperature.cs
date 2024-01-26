using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolRoutePlanner
{
    class Temperature
    {
        // Data members
        private double degree;
        private string scale;

        // Default Constructor
        public Temperature()
        {
            this.degree = 98.0;
            this.scale = "F";
        }

        // Overloaded Constructor
        public Temperature(double temp)
        {
            this.degree = temp;
            this.scale = "F";
        }

        // Property methods
        public double Degree
        {
            set { this.degree = value; }
            get { return Math.Round(this.degree, 1); }
        }

        public string Scale
        {
            get { return this.scale; }
            set { this.scale = value; }
        }

        // Class Methods
        public override string ToString()
        {
            string outStr = "Temperature: " + this.degree.ToString() + " " + this.scale.ToString();
            return outStr;
        }

        // Destructor
        ~Temperature() { }
    }
}
