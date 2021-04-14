using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace justTesting.Models.ViewModel
{
    //allows the program to iterate through pictures
    public class PictureListViewModel
    {
        IEnumerable<Pictures> PicList { get; set; }
    }
}
