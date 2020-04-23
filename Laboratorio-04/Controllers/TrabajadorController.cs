using Laboratorio_04.Models;
using Laboratorio_04.Helpers;
//using Laboratorio_04.PruebaA; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EO.Internal;

namespace Laboratorio_04.Controllers
{
    public class TrabajadorController : Controller
    {
        public List<Trabajador> ListaTrabajador = new List<Trabajador>();
        public List<Trabajador>[] HashArray = new List<Trabajador>[50];

        // GET: Trabajador
        public ActionResult Index()
        {
            return View(Storage.Instancia.ListaTrabajador);
        }

        // GET: Trabajador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trabajador/Create
        public ActionResult Create()
        {
            return View();
        }
        

        // POST: Trabajador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Trabajador[] trabajadorinf = ListaTrabajador.ToArray();
            Ordenalf(trabajadorinf, ListaTrabajador.Count);
            try
            {
                var trabajador = new Trabajador
                {
                    Titulo = collection["Titulo"],
                    idTitulo = collection["Titulo"],
                    Prioridad = int.Parse(collection["Prioridad"]),
                    Entrega = int.Parse(collection["Entrega"]),
                    Describetarea = collection["Describetarea"],
                    idtarea = collection["Describetarea"],
                    Proyecto = collection["Proyecto"],
                    idproyecto = collection["Proyecto"]
                };
                ListaTrabajador.Add(trabajador);
                if (trabajador.Save())
                {
                    NodoColaI tareas = new NodoColaI
                    {
                        Titulo = collection["Titulo"],
                        Prioridad = int.Parse(collection["Prioridad"]),
                        Entrega = int.Parse(collection["Entrega"]),
                        Describetarea = collection["Describetarea"],
                        Proyecto = collection["Proyecto"]
                    };
                 // NodoColaI ntarea = PriorityQ.Mostrar();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(trabajador);
                }
                // TODO: Add insert logic here
            }
            catch
            {
                return View();
            }
        }
    
        static void Ordenalf(Trabajador[] vector, int n)
        {
            Trabajador aux;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (vector[i].idTitulo != vector[j].idTitulo)
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;

                    }
                }
            }
        }
        
        // GET: Trabajador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trabajador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trabajador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trabajador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
