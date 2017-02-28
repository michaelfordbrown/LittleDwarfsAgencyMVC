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

        [HttpGet]
        public ActionResult CreateTimesheetSummary()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateTimesheetSummary(InvoiceList invoiceList)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                if (ModelState.IsValid)
                {
                    context.InvoiceLists.Add(invoiceList);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(invoiceList);
            }
        }


        public ActionResult Details(int id = 0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                InvoicesDetailsViewModel vm = new InvoicesDetailsViewModel()
                {
                    Invoice = context.Invoices.Find(id)
                };

                vm.InvoiceLists = context.InvoiceLists.Where(i => i.Invoice == vm.Invoice.Invoice1).ToList();

                return View(vm);
            }
        }

        public ActionResult TimesheetSummary(int id = 0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.InvoiceLists.Find(id));
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

        public ActionResult DeleteTimesheetSummary(int id = 0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.InvoiceLists.Find(id));
            }
        }

        [HttpPost, ActionName("DeleteTimesheetSummary")]
        public ActionResult delete_conf1(int id)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                InvoiceList inv = context.InvoiceLists.Find(id);
                context.InvoiceLists.Remove(inv);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
        public ActionResult Edit(int id = 0)
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


        public ActionResult EditTimesheetSummary(int id = 0)
        {
            using (LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1())
            {
                return View(context.InvoiceLists.Find(id));
            }
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult EditTimesheetSummary(InvoiceList i)
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
