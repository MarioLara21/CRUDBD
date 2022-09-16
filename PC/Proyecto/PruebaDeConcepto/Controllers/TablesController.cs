using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PruebaDeConcepto.Models;
namespace PruebaDeConcepto.Controllers
{
    public class TablesController : Controller
    {

        // GET: Tables
        public ActionResult Index()
        {
            List<Usuario> lst;
            using (BD_01Entities1 db = new BD_01Entities1())
            {
                 lst = (from d in db.Usuarios
                          select new Usuario
                          {
                            Id = d.Id,
                            Nombre = d.Nombre,
                            Clave = d.Clave,
                          }).ToList();
            }
            return View(lst);
        }
    }
}