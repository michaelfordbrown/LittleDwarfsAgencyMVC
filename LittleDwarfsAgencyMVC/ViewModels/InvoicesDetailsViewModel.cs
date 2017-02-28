using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LittleDwarfsAgencyMVC.ViewModels
{
    public class InvoicesDetailsViewModel
    {
        public Invoice Invoice { get; set; }
        public List<InvoiceList> InvoiceLists { get; set; }
    }
}