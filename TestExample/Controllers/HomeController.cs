using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestExample.Models;

namespace TestExample.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            var data = db.HangHoas.Where(x => x.Gia > 100).ToList();
            int total = data.Count();
            ViewBag.totalPage = total % 5 == 0 ? total / 5 : total / 5 + 1;
            data = data.Take(5).ToList();
            return View("Index", data);
        }

        public ActionResult LoadData(string search,int pageNumber, int categoryId)
        {
            var data = db.HangHoas.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                data =  data.Where(x => x.TenHang.ToLower().Contains(search.ToLower())).ToList();
            }
            if(categoryId > 0)
            {
                data = data.Where(x => x.LoaiHang.MaLoai == categoryId).ToList();
            }
            int total = data.Count();
            ViewBag.totalPage = total % 5 == 0 ? total / 5 : total / 5 + 1;
            ViewBag.pageNumber = pageNumber;
            data = data.Skip(5 * (pageNumber - 1)).Take(5).ToList();
            return PartialView("Index",data);
        }

        public ActionResult RenderHeader()
        {
            return PartialView("_Header",db.LoaiHangs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}