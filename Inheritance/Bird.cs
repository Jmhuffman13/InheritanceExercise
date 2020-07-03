using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LivesOutdoors = true;
            HasFur = false;
            Age = 5;

        }

        public bool CanFly { get; set; }
        public string BirdColor { get; set; }
        public int NumOfWings { get; set; }
        public int BeakLength { get; set; }




    }
}
