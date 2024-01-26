using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolRoutePlanner
{
    class Location
    {
        // Data members
        private int x;
        private int y;

        // Constructors
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Property Methods
        public int X
        {
            set { this.x = value; }
            get { return this.x; }
        }
        public int Y
        {
            set { this.y = value; }
            get { return this.y; }
        }
        // Class methods
        public override string ToString()
        {
            string outStr = "Location: (" + x.ToString() + ", " + y.ToString() + ")";
            return outStr;
        }

        // Destructor
        ~Location() { }
    }
}
