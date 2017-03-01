using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LittleDwarfsAgencyMVC.Controllers;
using LittleDwarfsAgencyMVC.Models;
using LittleDwarfsAgencyMVC.ViewModels;
using System.Web;
using System.Web.Mvc;
using LittleDwarfsAgencyMVC;

namespace ControllerTests
{
    [TestFixture]
    public class ControllerTestClass
    {
        [Test]
        public void TestInvoicesController()
        {
            var obj = new InvoicesController();

            var actResult = obj.Index() as ViewResult;

            Assert.That(actResult.ViewName.ToString(), Is.EqualTo(""));

        }

        [Test]
        public void TestInvoicesCreateRedirect()
        {
            var obj = new InvoicesController();

            RedirectToRouteResult result = obj.Create(new Invoice()
            {
                Invoice1 = 190,
                AccountRef = "Unit Test Ref",
                InvoiceDate = new DateTime(2017,03,01)
            }) as RedirectToRouteResult;


            Assert.That(result.RouteName, Is.EqualTo("Index"));

        }
    }
}
