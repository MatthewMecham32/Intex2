using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{
    public class PageNumberingInfo
    {
        //sets the variables to be passed from the controller to the views and so forth
        public int NumItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumItems { get; set; }

        //calculating how many pages
        public int NumPages => (int)(Math.Ceiling((decimal)TotalNumItems / NumItemsPerPage));
    }
}
