using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_DSW.ConsultaLugaresTuristicos
{
    public class LugaresTuristicosController : Controller
    {
         [HttpGet]
        public IEnumerable<LugarTuristico> Get()
        {
            // Realiza una consulta a la base de datos para obtener todos los lugares turísticos.

            return _context.LugaresTuristicos.ToList();
        } 
        
        
        
        // GET: LugaresTuristicosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LugaresTuristicosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LugaresTuristicosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LugaresTuristicosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LugaresTuristicosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LugaresTuristicosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LugaresTuristicosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LugaresTuristicosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      

    }
}
