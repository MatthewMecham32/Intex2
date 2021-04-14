using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{
    //returns info about a burial's arms and info about burial
    public class ArmViewmodel
    {
        public IEnumerable<Burial> Burials { get; set; }
        public IEnumerable<Arm> Arm { get; set; }
    }
}
