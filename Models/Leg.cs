using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class Leg
    {
        public int OurId { get; set; }
        public double? FemurHead { get; set; }
        public string FemurDiameter { get; set; }
        public string FemurLength { get; set; }
        public string TibiaLength { get; set; }
    }
}
