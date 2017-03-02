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
using Moq;

namespace ControllerTests
{
    [TestFixture]
    public class ControllerTestClass
    {
        //[Test]
        //public void TestInvoicesController()
        //{
        //    var obj = new InvoicesController();

        //    var actResult = obj.Index() as ViewResult;

        //    Assert.That(actResult.ViewName.ToString(), Is.EqualTo(""));

        //}

        //[Test]
        //public void TestInvoicesCreateRedirect()
        //{
        //    var obj = new InvoicesController();

        //    RedirectToRouteResult result = obj.Create(new Invoice()
        //    {
        //        Invoice1 = 190,
        //        AccountRef = "Unit Test Ref",
        //        InvoiceDate = new DateTime(2017,03,01)
        //    }) as RedirectToRouteResult;


        //    Assert.That(result.RouteName, Is.EqualTo("Index"));

        //}
        [Test]
        public void Invoice_Index_View_Contains_ListOfInvoices_Model()
        {
            //Arrange
            Mock<IInvoiceRepository> mock = new Mock<IInvoiceRepository>();

            mock.Setup(m => m.Invoices).Returns(new Invoice[]
            {
                new Invoice {Id = 1, Invoice1 = 1001, AccountRef = "TestData", InvoiceDate = new DateTime(2017,03,01) },
                new Invoice {Id = 2, Invoice1 = 1002, AccountRef = "TestData", InvoiceDate = new DateTime(2017,03,02) },
                new Invoice {Id = 3, Invoice1 = 1003, AccountRef = "TestData", InvoiceDate = new DateTime(2017,03,03) },
                new Invoice {Id = 4, Invoice1 = 1005, AccountRef = "TestData", InvoiceDate = new DateTime(2017,03,04) }
            }.AsQueryable());

            InvoicesController controller = new InvoicesController(mock.Object);

            // Act
            var actual = (List<Invoice>)controller.Index().Model;

            // Assert
            Assert.IsInstanceOf<List<Invoice>>(actual);
        }
    }
}
