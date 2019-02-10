using ClothBazar.services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class SharedController : Controller
    {
        public CatogeryService context = new CatogeryService();
        // GET: Shared
        [HttpPost]
        public JsonResult  UploadImage()
        {
            
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            try
            {
                var file = Request.Files[0];
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                file.SaveAs(path);
                result.Data = new { Success = true, ImageURL = string.Format("/Content/images/{0}" , fileName) };
            }
            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            } return result;
        }
    }
}