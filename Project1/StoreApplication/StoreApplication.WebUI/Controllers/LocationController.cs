using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApplication.DataAccess;
using StoreApplication.Library;
using StoreApplication.WebUI.Models;

namespace StoreApplication.WebUI.Controllers
{
    public class LocationController : Controller
    {
        public StoreApplicationRepository Repo { get; }

        public LocationController(StoreApplicationRepository repo) =>
            Repo = repo ?? throw new ArgumentNullException(nameof(repo));
        // GET: Location
        public ActionResult Index([FromQuery]string search = "")
        {
            IEnumerable<Library.Location> locations = Repo.GetLocation(search);
            IEnumerable<LocationViewModel> viewModels = locations.Select(x => new LocationViewModel
            {
                Id = x.Id,
                Name = x.Name,
                //Reviews = x.Reviews.Select(y => new ReviewViewModel()),
                Street = x.Street,
                City = x.City,
                State = x.State
                //LocationName = x.CustLocation.Name
                //Score = x.Score
            });

            return View(viewModels);
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            Library.Location location = Repo.GetLocationById(id);
            IEnumerable<Order> orders = Repo.GetOrdersLoc(id, location);
            //String products = Repo.GetProducts(id);
            IEnumerable<OrderViewModel> viewModels = orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                //FirstName 
                //Reviews = x.Reviews.Select(y => new ReviewViewModel()),
                //LastName = customer.LastName,
                LocationName = location.Name,
                OrderTime = x.OrderTime,
                Products = x.ProductsOrdered,
                Price = x.Price

                //Score = x.Score
            });
            return View(viewModels);
        }
    

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Location/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Location/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}