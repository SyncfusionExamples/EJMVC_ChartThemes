using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ChartData> data = new List<ChartData>();
            data.Add(new ChartData(1, 17));
            data.Add(new ChartData(2, 20));
            data.Add(new ChartData(3, 33));
            data.Add(new ChartData(4, 18));
            data.Add(new ChartData(5, 13));
            data.Add(new ChartData(6, 15));
            data.Add(new ChartData(7, 19));
            data.Add(new ChartData(8, 37));
            data.Add(new ChartData(9, 16));
            data.Add(new ChartData(10, 28));
            ///...
            ViewBag.ChartData = data;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public class ChartData
        {
            public double Month;
            public double Sales;
            public ChartData(double month, double sales)
            {
                this.Month = month;
                this.Sales = sales;
            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}