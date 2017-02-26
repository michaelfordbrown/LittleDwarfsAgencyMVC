using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LittleDwarfsAgencyMVC.ViewModels
{
    public class RandomInvoiceViewModel
    {
        public Invoice Invoice { get; set; }
        public List<Timesheet> Timesheets { get; set; }
    }
}