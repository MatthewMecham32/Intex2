using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class Arm
    {
        public int OurId { get; set; }
        public double? HumerusHead { get; set; }
        public double? MedialClavicle { get; set; }
        public double? Humerus { get; set; }
        public double? HumerusLength { get; set; }
    }
}
