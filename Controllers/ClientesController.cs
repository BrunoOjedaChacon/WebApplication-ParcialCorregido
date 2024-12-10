using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_ParcialCorregido.Models;

namespace WebApplication_ParcialCorregido.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Clientes.ToList());
            }
               
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Clientes.Where(x => x.ClienteId == id).FirstOrDefault());
            }
               
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View();
            }
               
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes clientesArray)
        {
            try
            {
                // TODO: Add insert logic here
                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    contexto.Clientes.Add(clientesArray);
                    contexto.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Clientes.Where(x => x.ClienteId == id).FirstOrDefault());
            }
                
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Clientes clientesArray)
        {
            try
            {
                // TODO: Add update logic here
                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    contexto.Entry(clientesArray).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    contexto.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Clientes.Where(x => x.ClienteId == id).FirstOrDefault());
            }
                
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    Clientes objClientes = contexto.Clientes.Where(x => x.ClienteId == id).FirstOrDefault();
                    contexto.Clientes.Remove(objClientes);
                    contexto.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
