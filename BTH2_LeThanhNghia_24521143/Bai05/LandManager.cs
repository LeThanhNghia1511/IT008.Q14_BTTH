using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class LandManager
    {
        private int n; // Number of lands
        private Land[] lands;

        public LandManager(int n = 0)
        {
            this.n = n;
            this.lands = new Land[n];
            for (int i = 0; i < this.n; i++)
            {
                this.lands[i] = new Land();
            }
        }

        public void Input()
        {
            Console.Write("Enter the number of lands: ");
            string inputValue = Console.ReadLine();
            if (!int.TryParse(inputValue, out this.n) || this.n < 0)
            {
                Console.WriteLine("Invalid data!");
                Environment.Exit(0);
            }
            this.lands = new Land[n];
            int type;
            for (int i = 0; i < this.n; i++)
            {
                Console.Write("Choose the type of land (1. Land, 2. TownHouse, 3. Apartment): ");
                string inputType = Console.ReadLine();
                if (!int.TryParse(inputType, out type))
                {
                    Console.WriteLine("Invalid data!");
                }
                switch (type)
                {
                    case 1:
                        this.lands[i] = new Land();
                        break;
                    case 2:
                        this.lands[i] = new TownHouse();
                        break;
                    default:
                        this.lands[i] = new Apartment();
                        break;
                }

                Console.WriteLine("Enter the {0} land information: ", i + 1);
                this.lands[i].Input();
            }
        }

        public void Output()
        {
            Console.WriteLine("The lands:");
            for (int i = 0; i < this.n; i++)
            {
                Console.WriteLine("{0}.", i + 1);
                this.lands[i].Output();
                Console.WriteLine();
            }
        }

        public void PrintTotalPrice()
        {
            long totalLand = 0;
            long totalTownHouse = 0;
            long totalApartment = 0;
            for (int i = 0;  i < this.n; i++)
            {
                totalLand += this.lands[i].GetPriceWithType(typeof(Land));
                totalTownHouse += this.lands[i].GetPriceWithType(typeof(TownHouse));
                totalApartment += this.lands[i].GetPriceWithType(typeof(Apartment));
            }

            Console.WriteLine("The total price of lands:");
            Console.WriteLine("The total price of all lands is: {0}", totalLand);
            Console.WriteLine("The total price of all townhouse is: {0}", totalTownHouse);
            Console.WriteLine("The total price of all apartment is: {0}", totalApartment);
        }

        // Print Lands with area > 100m2 || (TownHouses with area > 60m2 && DateTime.year >= 2019)
        public void PrintLandsWithConditions()
        {
            int no = 1;
            bool isEmpty = true;
            // Compare the condition
            bool isMeetFirstCondition;
            bool isMeetSecondCondition;
            Console.WriteLine("Lands or townhouses that meet the conditions:");
            for (int i = 0; i < this.n; i++)
            {
                isMeetFirstCondition = this.lands[i].GetType().Name == "Land" && this.lands[i].GetArea() > 100;
                isMeetSecondCondition = this.lands[i].GetType().Name == "TownHouse" && this.lands[i].GetArea() > 65 && this.lands[i].GetBuildYear() >= 2019;
                if (isMeetFirstCondition || isMeetSecondCondition)
                {
                    isEmpty = false;
                    Console.WriteLine("{0}. ", no);
                    no++;
                    this.lands[i].Output();
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("Empty list!");
            }
        }

        // Enter the searching condition (location, price, area) then print all the townhouses or apartments that meet the condition
        // The locations string ignore case
        // price <= search price
        // area >= search area
        public void Search()
        {
            string searchLocation;
            long searchPrice;
            int searchArea;

            Console.WriteLine("Enter the searching information: ");
            Console.Write("Enter the searching location: ");
            searchLocation = Console.ReadLine();
            Console.Write("Enter the searching price: ");
            string inputSearchPrice = Console.ReadLine();
            if (!long.TryParse(inputSearchPrice, out searchPrice) || searchPrice < 0)
            {
                Console.WriteLine("Invalid data");
            }
            Console.Write("Enter the searching area: ");
            string inputSearchArea = Console.ReadLine();
            if (!int.TryParse(inputSearchArea, out searchArea) || searchArea < 0)
            {
                Console.WriteLine("Invalid data");
            }

            // Compare the condition
            bool isMeetFirstCondition;
            bool isMeetSecondCondition;
            bool isMeetThirdCondition;
            int no = 1;
            bool isEmpty = true;
            Console.WriteLine("The townhouses or apartments that meet the conditions:");
            for (int i = 0; i < this.n; i++)
            {
                isMeetFirstCondition = this.lands[i].GetLocation().Equals(searchLocation, StringComparison.OrdinalIgnoreCase);
                isMeetSecondCondition = this.lands[i].GetPrice() <= searchPrice;
                isMeetThirdCondition = this.lands[i].GetArea() >= searchArea;
                if (isMeetFirstCondition && isMeetSecondCondition && isMeetThirdCondition)
                {
                    isEmpty = false;
                    Console.WriteLine("{0}.", no);
                    no++;
                    this.lands[i].Output();
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("Empty list!");
            }
        }
    }
}
