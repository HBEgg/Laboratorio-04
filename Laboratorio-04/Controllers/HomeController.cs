using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio_04.Models; 
using System.Web.Mvc;
using System.IO;

namespace Laboratorio_04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new List<Trabajador>());
        }
            [HttpPost]
            public ActionResult Index(HttpPostedFileBase postedFile)
            {
            List<Trabajador> Trabajador = new List<Trabajador>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/PruebaA");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path); 
                }
                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                string csvdata = System.IO.File.ReadAllText(filePath);
                foreach (string row in csvdata.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        Trabajador.Add(new Trabajador
                        {
                            Titulo =row.Split(',')[0], 
                            Describetarea = row.Split(',')[1],
                            Proyecto = row.Split(',')[2],
                            Prioridad = Convert.ToInt32(row.Split(',')[4]), 
                            Entrega = Convert.ToInt32(row.Split(',')[5])

                        }); 
                            
                    }
                }
            }
            return View(Trabajador);
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