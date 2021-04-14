using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace justTesting.Models
{
    public class FileUrl
    {
        public string Url { get; set; }

        public string Type { get; set; }

        public Burial Burial { get; set; }

        public int Our_Burial_ID { get; set; }

        public FileUrl (Burial burial)
            {


            }
        
    }
}
