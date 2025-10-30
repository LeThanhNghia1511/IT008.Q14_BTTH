using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class TownHouse : Land
    {
        private int buildYear;
        private int numOfStage;

        public TownHouse(int buildYear = 1, int numOfStage = 1)
        {
            this.buildYear = buildYear;
            this.numOfStage = numOfStage;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter the build year: ");
            string inputBuildYear = Console.ReadLine();
            if (!int.TryParse(inputBuildYear, out this.buildYear) || this.buildYear < 0)
            {
                Console.WriteLine("Invalid data!");
            }
            Console.Write("Enter the number of stages of the townhouse: ");
            string inputnumOfStage = Console.ReadLine();
            if (!int.TryParse(inputnumOfStage, out this.numOfStage) || this.numOfStage < 0)
            {
                Console.WriteLine("Invalid data!");
            }
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Build year: {0}", this.buildYear);
            Console.WriteLine("Number of stages: {0}", this.numOfStage);
        }

        public override int GetBuildYear()
        {
            return this.buildYear;
        }
    }
}
