using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolRoutePlanner
{
    class Pool
    {
        // Data members
        private Temperature temp;
        private Location location;
        private string name;

        // Static Data member
        public static int Count = 0;

        // Overloaded Constructors
        public Pool(double temp, int x, int y)
        {
            Console.WriteLine("Number of pools is {0}.", Count);
            Console.WriteLine("Creating a new pool object....");
            this.name = "";
            this.temp = new Temperature(temp);
            this.location = new Location(x, y);
            Count += 1;
            Console.WriteLine(this.ToString());
            Console.WriteLine("Number of pools is now {0}.\n", Count);
        }

        public Pool(string name, double temp, int x, int y)
        {
            Console.WriteLine("Number of pools is {0}.", Count);
            Console.WriteLine("Creating a new pool object....");
            this.name = name;
            this.temp = new Temperature(temp);
            this.location = new Location(x, y);
            Count += 1;
            Console.WriteLine(this.ToString());
            Console.WriteLine("Number of pools is now {0}.\n", Count);
        }

        // Property method
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        // Class methods
        public double GetTemperature()
        {
            return this.temp.Degree;
        }

        public string GetScale()
        {
            return this.temp.Scale;
        }

        public override string ToString()
        {
            string outStr = "Pool " + name + "\n" + temp.ToString() + "\n" + location.ToString();
            return outStr;
        }

        public void FindDistance(Pool[] pools)
        {
            // Create an Array List to add the pool objects in order that are closes to nearest location
            ArrayList arrList = new ArrayList();
            List<Pool> poolList = new List<Pool>(pools);

            // Declare starting x and y coordinates
            int x1 = 0;
            int y1 = 0;

            int count = 0;
            // Traverse the array and rearrange the array with shortest path
            while (count < Count)
            {
                int indexOfPath = 0;
                double shortestPath = DistanceFormula(x1, poolList[0].location.X, y1, poolList[0].location.Y);
                for (int i = 0; i < poolList.Count; i++)
                {
                    double path = DistanceFormula(x1, poolList[i].location.X, y1, poolList[i].location.Y);

                    if (path < shortestPath)
                    {
                        indexOfPath = i;
                        shortestPath = path;
                    }
                }
                x1 = poolList[indexOfPath].location.X;
                y1 = poolList[indexOfPath].location.Y;
                
                pools[count] = poolList[indexOfPath];
                count += 1;
                poolList.RemoveAt(indexOfPath);
            }

            // Display the order of the maintaince crew route
            for (int i = 0; i < Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("(0, 0) ");
                }
                Console.Write(">> {0} with temperature at {1} degrees {2} ", pools[i].Name, pools[i].GetTemperature(), pools[i].GetScale());
            }
            Console.WriteLine();
        }

        // Distance formula function
        public double DistanceFormula(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        // Destructor
        ~Pool() { }
    }
}
