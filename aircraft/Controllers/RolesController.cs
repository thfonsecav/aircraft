using System.Web.Mvc;
using Aircraft.DA;
using Aircraft.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Aircraft.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class RolesController : Controller
    {
        AircraftContext context;

        public RolesController()
        {
            context = new AircraftContext();
        }



        // GET: /Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Roles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                context.Roles.Add(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
                {
                    Name = collection["RoleName"]
                });
                context.SaveChanges();
                ViewBag.ResultMessage = "Role created successfully !";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



    }
}
