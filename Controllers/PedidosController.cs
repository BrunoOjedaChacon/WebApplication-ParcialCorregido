using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_ParcialCorregido.Models;

namespace WebApplication_ParcialCorregido.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Pedidos.ToList());
            }
                
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Pedidos.Where(x => x.PedidoId == id).FirstOrDefault());
            }
                
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View();
            }
                
        }

        // POST: Pedidos/Create
        [HttpPost]
        public ActionResult Create(Pedidos pedidosArray)
        {
            try
            {
                // TODO: Add insert logic here

                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    contexto.Pedidos.Add(pedidosArray);
                    contexto.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Pedidos.Where(x => x.PedidoId == id).FirstOrDefault());
            }
                
        }

        // POST: Pedidos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pedidos pedidosArray)
        {
            try
            {
                // TODO: Add update logic here

                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    contexto.Entry(pedidosArray).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    contexto.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int id)
        {
            using (VentasParcial2Entities contexto = new VentasParcial2Entities())
            {
                return View(contexto.Pedidos.Where(x => x.PedidoId == id).FirstOrDefault());
            }
        }

        // POST: Pedidos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (VentasParcial2Entities contexto = new VentasParcial2Entities())
                {
                    Pedidos objPedidos = contexto.Pedidos.Where(x => x.PedidoId == id).FirstOrDefault();
                    contexto.Pedidos.Remove(objPedidos);
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
