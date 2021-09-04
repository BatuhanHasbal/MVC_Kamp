using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKamp.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager im = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var imagefileList = im.GetList();
            return View(imagefileList);
        }
    }
}