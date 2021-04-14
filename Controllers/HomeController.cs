using justTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using justTesting.Models.ViewModel;
using justTesting.Models.BurialListViewModel;
using System.IO;
using justTesting.Models.ViewModel;
using com.sun.org.apache.xml.@internal.resolver.helpers;
using justTesting.Services;

namespace justTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> signInManager;
        private MummyDataContext context;
        private IS3Service _s3storage;

        //constructor
        public HomeController(ILogger<HomeController> logger, MummyDataContext cnt, SignInManager<IdentityUser> signInManager, IS3Service storage)
        {
            context = cnt;
            _logger = logger;
            _s3storage = storage;
            this.signInManager = signInManager;
        }


        //displays the home page, along with 4 burials
        [AllowAnonymous]
        public IActionResult Index()
        {
            IEnumerable<Burial> burials = context.Burial
                                          .Take(4);

            return View(burials);
            
        }
        
        //if the user is an admin or a researcher, takes them to the "EditBurial" view where they can view/edit information about a burial
        [HttpGet]
        [Authorize(Roles = "Admins, Researcher")]
        public IActionResult EditBurial(Burial burial)
        {

            IEnumerable<Burial> burials = context.Burial
                .Where(b => b.OurId == burial.OurId);

            return View("EditBurial", burials);

        }

        //if a user is an admin or a researcher, allows them to submit information to be saved in the database about a certain record
        [HttpPost]
        [Authorize(Roles = "Admins, Researcher")]
        public IActionResult EditBurialPostBurial (Burial burial)
        {
            context.Burial.Update(burial);
            context.SaveChanges();
            ViewBag.SelectedID = burial.OurId;
            return View("ViewDetails", burial);

        }


        //set the action to access the burial form view when the user is requesting it
        [Authorize(Roles = "Admins, Researcher")]
        [HttpGet]
        public IActionResult AddBurial()
        {
            return View();
        }

        //set the action to access the burial form view for posting information

        [HttpPost]
        [Authorize(Roles = "Admins, Researcher")]
        public IActionResult AddBurial(Burial burial)
        {
            if (ModelState.IsValid)
            {
                burial.OurId = context.Burial.Max(b => b.OurId) + 1;
                burial.BurialId = burial.BurialLocationNs + " " + burial.LowPairNs + "/" + burial.HighPairNs + " " + burial.BurialLocationEw + " " + burial.LowPairEw + "/" + burial.HighPairEw + " " + burial.BurialSubplot + " #" + burial.BurialNumber;
                context.Burial.Add(burial);
                context.SaveChanges();
                ViewBag.SelectedID = burial.OurId;
                return View("ViewDetails", burial);
            }
            else
            {
                return View("AddBurial");
            }
        }

        //set the action to access the burial form view when the user is requesting it
        [Authorize(Roles = "Admins, Researcher")]
        [HttpGet]
        public IActionResult AddFieldBurial()
        {
            return View();
        }

        //set the action to access the burial form view for posting information

        [HttpPost]
        [Authorize(Roles = "Admins, Researcher")]
        public IActionResult AddFieldBurial(Burial burial)
        {
            if (ModelState.IsValid)
            {
                burial.OurId = context.Burial.Max(b => b.OurId) + 1;
                burial.BurialId = burial.BurialLocationNs + " " + burial.LowPairNs + "/" + burial.HighPairNs + " " + burial.BurialLocationEw + " " + burial.LowPairEw + "/" + burial.HighPairEw + " " + burial.BurialSubplot + " #" + burial.BurialNumber;
                context.Burial.Add(burial);
                context.SaveChanges();
                ViewBag.SelectedID = burial.OurId;
                return View("ViewDetails", burial);
            }
            else
            {
                return View("AddFieldBurial");
            }
        }


        //displays the BurialList view, which displays 60 burials on each page
        public IActionResult BurialList(string BurialId ="all",string HairColor = "all", string Gender = "all", int BurialDepth = -1, string HeadDirection = "all", int pageNum =1)
        {

            //allows for filtering
            IQueryable<Burial> Please = context.Burial;
            if (BurialId != "all")
            {
                Please = Please.Where(b => b.BurialId == BurialId);
            }
            if (HairColor != "all")
            {
                Please = Please.Where(b => b.HairColor == HairColor);
            }
            if (Gender != "all")
            {
                Please = Please.Where(b => b.GenderGe == Gender);
            }

            if(BurialDepth != -1)
            {
                Please = Please.Where(b => b.BurialDepthMeters == BurialDepth);
            }
            if (HeadDirection != "all")
            {
                Please = Please.Where(b => b.HeadDirection == HeadDirection);
            }

            

            int pageSize = 60;

            //returns the BurialList view along with 60 burials and page numbering info
            return View("BurialList", new BurialListViewModel
            {
                Burials = Please
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = Please.Count()
                }
            });
        }





        //loads the login view
        [HttpGet]
        public IActionResult LoginGet()
        {
            return View("Login");
        }

        //submits login information
        [HttpPost]
        public IActionResult LoginPost()
        {
            return View("Index");
        }

        //allows user to create an account 
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        //allows the user to pass new account info to be able to save it to the DB
        [HttpPost]
        public IActionResult CreateAccountPost()
        {
            //Pass in the user information and save it in the DB
            return View("Index");
        }




        //logs the user out of session
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }





        ////grabs the information for the arm page
        [HttpGet]
        public IActionResult ArmInfo(Burial burial)
        {

            //returns info about a specific arm
            return View("ArmInfo", new ArmViewmodel
            {

                Burials = context.Burial
             .Where(m => m.OurId == burial.OurId)
             .ToList(),

                Arm = context.Arm
                .Where(m => m.OurId == burial.OurId)
                .ToList()
            });

        }

        ////grabs the information for the leg page
        [HttpGet]
        public IActionResult LegInfo(Burial burial)
        {

            
            return View("LegInfo", new LegViewModel
            {

                Burials = context.Burial
                .Where(m => m.OurId == burial.OurId)
                .ToList(),

                Leg = context.Leg
                .Where(m => m.OurId == burial.OurId)
                .ToList()
            });

        }


        ////grabs the information for the hip page
        [HttpGet]
        public IActionResult HipInfo(Burial burial)
        {
            IEnumerable<Hips> HipsQuery = context.Hips;

            return View("HipInfo", new HipViewModel
            {

                Burials = context.Burial
                .Where(m => m.OurId == burial.OurId)
                .ToList(),

                Hip = context.Hips
                .Where(m => m.OurId == burial.OurId)
                .ToList()
            });

        }

        ////grabs the information for the head page
        [HttpGet]
        public IActionResult HeadInfo(Burial burial)
        {

            return View("HeadInfo", new HeadViewModel
            {

                Burials = context.Burial
                .Where(m => m.OurId == burial.OurId)
                .ToList(),

                Head = context.Head
                .Where(m => m.OurId == burial.OurId)
                .ToList()
            });

        }


        //displays specific details of a burial record
        [HttpGet]
        public IActionResult ViewDetails(Burial burial)
        {
            ViewBag.SelectedID = burial.OurId;
            return View("ViewDetails", burial);

        }


        //takes care of uploading s3 data
        //public async Task<IActionResult> FileUploadForm()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> FileUploadForm(FileUploadFormModal FileUpload)
        //{

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        await FileUpload.FormFile.CopyToAsync(memoryStream);

        //        // Upload the file if less than 2 MB
        //        if (memoryStream.Length < 5000000)
        //        {
        //            await S3Upload.UploadFileAsync(memoryStream, "testbucket1asdf", "ZsqjXqVFZ4F1YVCcmJZNilOojwnzHaozHwSdp2dF");
        //            //ACL Request
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("File", "The file is too large.");
        //        }
        //    }

        //    return View();
        //}



        //allows the user to upload photos to an S3 instance
        [HttpPost]
        public async Task<IActionResult> SavePhotos(SavePhotoViewModel SavePhoto, int id)
        {
            if (ModelState.IsValid)
            {

                string url = await _s3storage.AddItem(SavePhoto.PhotoFile, "testGuy");
                Burial burial_to_add = context.Burial.Where(b => b.OurId == id).FirstOrDefault();

                Pictures FileRecord = new Pictures()
                {
                    PicUrl = url,
                    PicId = context.Pictures
                    .Select(p=> p.PicId)
                    .Last() + 1,
                    OurID = id,
                    Type = SavePhoto.Type
                };

                context.Pictures.Add(FileRecord);
                context.SaveChanges();
                ViewBag.SelectedID = ViewBag.OurID;
                return View("ViewDetails", burial_to_add);
            }
            else
            {
                return View("PhotoUploadForm");
            }
        }


        //brings the view that will allow the user to upload the photo
        public IActionResult UploadPhotos(Burial burial)
        {
            ViewBag.OurID = burial.OurId;
            return View("PhotoUploadForm");
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
