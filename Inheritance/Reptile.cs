using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            LivesOutdoors = true;
            HasFur = true;
            Age = 7;

        }

        public int NumOfLegs { get; set; }
        public bool HasClaws { get; set; }
        public string NativeTo { get; set; }
        public bool HasTeeth { get; set; }
    }
}
