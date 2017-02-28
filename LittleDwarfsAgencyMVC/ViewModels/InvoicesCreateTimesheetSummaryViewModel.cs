using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LittleDwarfsAgencyMVC.ViewModels
{
    public class InvoicesCreateTimesheetSummaryViewModel
    {
        public int invoice { get; set; }
        public InvoiceList InvoiceList { get; set; }
    }
}