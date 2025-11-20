using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Apartment : Land
    {
        private int stage;

        public Apartment(int stage = 1)
        {
            this.stage = stage;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter the stage of the apartment: ");
            string inputStage = Console.ReadLine();
            if (!int.TryParse(inputStage, out this.stage) || this.stage < 0)
            {
                Console.WriteLine("Invalid data!");
            }
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Stage: {0}", this.stage);
        }
    }
}
