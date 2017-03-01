using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleDwarfsAgencyMVC.Models
{
    public interface IInvoiceRepository
    {
        IQueryable<Invoice> Invoices { get; }
        Invoice Save(Invoice invoice);
        void Delete(Invoice invoice);
    }
}
