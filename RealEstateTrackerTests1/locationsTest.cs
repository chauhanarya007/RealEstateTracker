using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate_Tracker.Data;
using RealEstate_Tracker.Controllers;
using RealEstate_Tracker.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace locationsTest
{
    [TestClass]
    public class LocationsTest
    {

        private ApplicationDbContext _context;
        private LocationsController _controller;
        private List<Location> _services = new List<Location>();



        [TestInitialize]
        public void TestInitialize()
        {


            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                .Options;
            _context = new ApplicationDbContext(options);




            var location1 = new Location { LocationId = 1, City = "Barrie" };
            var location2 = new Location { LocationId = 2, City = "Toronto" };
            var location3 = new Location { LocationId = 3, City = "Huntsville" };


            _context.Locations.Add(location1);
            _context.Locations.Add(location2);
            _context.Locations.Add(location3);
            _context.SaveChanges();


            _services.Add(location1);
            _services.Add(location2);
            _services.Add(location3);


            _controller = new LocationsController(_context);
        }

        [TestMethod]
        public void Methodone()
        {

            var actResult1 = _controller.Edit(null);
            var Result1 = (NotFoundResult)actResult1.Result;
            Assert.AreEqual(404, Result1.StatusCode);
        }

        [TestMethod]
        public void Methodtwo()
        {
            var actResult2 = _controller.Edit(100);
            var Result2 = (NotFoundResult)actResult2.Result;
            Assert.AreEqual(404, Result2.StatusCode);
        }

        [TestMethod]
        public void Methodthree()
        {
            var actResult3 = _controller.Edit(1);
            var Result3 = (ViewResult)actResult3.Result;
            Assert.IsNotNull(Result3);
        }



    }
}