using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoseProject.Models;
using System.Data.Entity;
using System.IO;


namespace ShoseProject.Controllers
{
    public class shoseController : Controller
    {
        // GET: shose

        shoseShopDBEntities db = new shoseShopDBEntities();
        public ActionResult Index()
        {
            var ProdList = db.tbl_detail.Include(p => p.tbl_typestyle);
            return View(ProdList.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.typeStyleID = new SelectList(db.tbl_typestyle, "typeStyleID", "typeName");
            ViewBag.typeColourID = new SelectList(db.tbl_typeColour, "typeColourID", "typeColour");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_detail NewProduct, HttpPostedFileBase file)
        {
            string myfile = Path.GetFileName(file.FileName);
            file.SaveAs(Server.MapPath("~/Imageshoes/" + myfile));
            if (ModelState.IsValid)
            {
                NewProduct.image = "~/Imageshoes/" + myfile;
                db.tbl_detail.Add(NewProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.typeStyleID = new SelectList(db.tbl_typestyle, "typeStyleID", "typeName");
            ViewBag.typeColour = new SelectList(db.tbl_typeColour, "typeColourID", "typeColour");
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }



    }
}