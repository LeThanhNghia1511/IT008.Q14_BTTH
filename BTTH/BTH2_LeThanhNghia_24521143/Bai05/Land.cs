using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bai05
{
    internal class Land
    {
        protected string location; // Location of the land
        protected long price; // Price of the land
        protected int area; // m^2

        public Land(string location = "", long price = 0, int area = 0)
        {
            this.location = location;
            this.price = price;
            this.area = area;
        }

        public virtual void Input()
        {
            Console.Write("Enter the location of the land: ");
            this.location = Console.ReadLine();
            Console.Write("Enter the price of the land: ");
            string inputPrice = Console.ReadLine();
            if (!long.TryParse(inputPrice, out this.price) || this.price < 0)
            {
                Console.WriteLine("Invalid data!");
            }
            Console.Write("Enter the area of the land (m^2): ");
            string inputArea = Console.ReadLine();
            if (!int.TryParse(inputArea, out this.area) || this.area < 0)
            {
                Console.WriteLine("Invalid data!");
            }
        }

        public virtual void Output()
        {
            Console.WriteLine("Location: {0}", this.location);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("Area: {0}", this.area);
        }

        public string GetLocation()
        {
            return this.location;
        }

        public long GetPrice()
        {
            return this.price;
        }

        public long GetPriceWithType(Type type)
        {
            if (this.GetType() == type)
            {
                return this.price;
            }
            return 0;
        }

        public int GetArea()
        {
            return this.area;
        }

        public virtual int GetBuildYear()
        {
            return 0;
        }
    }
}
