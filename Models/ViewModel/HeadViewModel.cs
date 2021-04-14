using justTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{
    //returns info about a burial's head and info about burial
    public class HeadViewModel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public IEnumerable<Head> Head { get; set; }
    }
}