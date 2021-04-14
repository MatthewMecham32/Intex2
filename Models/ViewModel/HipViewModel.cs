using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{
    //returns info about a burial's hips and info about burial

    public class HipViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public IEnumerable<Hips> Hip { get; set; }
    }
}