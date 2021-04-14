using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{

    //returns info about a burial's legs and info about burial

    public class LegViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public IEnumerable<Leg> Leg { get; set; }
    }
}