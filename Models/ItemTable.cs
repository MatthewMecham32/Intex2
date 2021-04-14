using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class ItemTable
    {
        public string ItemId { get; set; }
        public int? BurialId { get; set; }
        public string BurialNumber { get; set; }
        public string ItemDescription { get; set; }
    }
}
