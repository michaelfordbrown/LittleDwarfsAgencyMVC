using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LittleDwarfsAgencyMVC.ViewModels;
using System.Data;
using System.Data.Entity;

namespace LittleDwarfsAgencyMVC.Controllers
{
    public class InvoicesController : Controller
    {

        public ActionResult Index()
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {

                return View(context.Invoices.ToList());
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Invoice invoice)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                if (ModelState.IsValid)
                {
                    context.Invoices.Add(invoice);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(invoice);
            }
        }

        public ActionResult Details(int id =0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.Invoices.Find(id));
            }
        }

        public ActionResult Delete(int id = 0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.Invoices.Find(id));
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult delete_conf(int id)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                Invoice inv = context.Invoices.Find(id);
                context.Invoices.Remove(inv);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        public ActionResult Edit(int id=0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.Invoices.Find(id));
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Invoice i)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                context.Entry(i).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}