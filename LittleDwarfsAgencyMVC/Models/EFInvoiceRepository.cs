using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace LittleDwarfsAgencyMVC.Models
{
    public class EFInvoiceRepository : IInvoiceRepository
    {

        LittleDwarfAgencyEntities1 context = new LittleDwarfAgencyEntities1();

        public IQueryable<Invoice> Invoices
        { get { return context.Invoices; } }

        public Invoice Save(Invoice invoice)
        {
            if (invoice.Id == 0)
            {
                context.Invoices.Add(invoice);
            }
            else
            {
                context.Entry(invoice).State = EntityState.Modified;
            }
            context.SaveChanges();
            return invoice;
        }

        public void Delete(Invoice invoice)
        {
            context.Invoices.Remove(invoice);
            context.SaveChanges();
        }
    }
}