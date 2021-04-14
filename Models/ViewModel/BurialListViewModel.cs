using justTesting.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.BurialListViewModel
{
    //returns info about a page numbering and info about burial

    public class BurialListViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public PageNumberingInfo PageNumberingInfo { get; set; }
    }
}
