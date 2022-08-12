using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hairsalon.Data;
using Hairsalon.Controllers;
using Hairsalon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace HairsalonTests
{
    [TestClass]
    public class locationTest
    {

        private ApplicationDbContext _context;
        private ServicesController _controller;
        private List<Service> _services = new List<Service>();



        [TestInitialize]
        public void TestInitialize()
        {


            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                .Options;
            _context = new ApplicationDbContext(options);




            var service1 = new Service { ServiceId = 1, ServiceName = "Haircut" };
            var service2 = new Service { ServiceId = 2, ServiceName = "Hairwash" };
            var service3 = new Service { ServiceId = 3, ServiceName = "Beardshave" };


            _context.Services.Add(service1);
            _context.Services.Add(service2);
            _context.Services.Add(service3);
            _context.SaveChanges();


            _services.Add(service1);
            _services.Add(service2);
            _services.Add(service3);


            _controller = new ServicesController(_context);
        }

        [TestMethod]
        public void Method1()
        {

            var actionResult = _controller.Delete(null);
            var Result1 = (NotFoundResult)actionResult.Result;
            Assert.AreEqual(404, Result1.StatusCode);
        }

        [TestMethod]
        public void Method2()
        {
            var actionResult2 = _controller.Delete(100);
            var Result2 = (NotFoundResult)actionResult2.Result;
            Assert.AreEqual(404, Result2.StatusCode);
        }

        [TestMethod]
        public void Method3()
        {
            var actionResult3 = _controller.Delete(1);
            var Result3 = (ViewResult)actionResult3.Result;
            Assert.IsNotNull(Result3);
        }



    }
}