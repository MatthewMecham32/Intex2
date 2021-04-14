using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using justTesting.Models;

namespace justTesting.Components
{

    //this class helps us to upload photos to the S3 instance
    public class PictureViewComponent : ViewComponent
    {
        private MummyDataContext context;


        public PictureViewComponent(MummyDataContext ctxt)
        {
            context = ctxt;
        }

        public IViewComponentResult Invoke()
        {

            int OURID = ViewBag.SelectedID;

            IEnumerable<Pictures> Pic = context.Pictures
                .Where(p => p.OurID == OURID)
                ;

            int NumItems = Pic.Count();
            NumItems = NumItems + 1;
            return View(context.Pictures
                .Where(p => p.OurID == OURID)
                .Take(1)
                );
        }
    }
}
