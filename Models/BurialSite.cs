using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace justTesting.Models
{
    public partial class BurialSite
    {
        public string SiteId { get; set; }
        public int? Nslow { get; set; }
        public int? Nshigh { get; set; }
        public string Ns { get; set; }
        public string Ewlow { get; set; }
        public int? Ewhigh { get; set; }
        public string Ew { get; set; }
        public string BurialSiteId { get; set; }
    }
}
