using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeCareService;
using HomeCareService.Models;
using HomeCareService.ViewModels;
using System.Diagnostics;

namespace HomeCareService.Controllers
{
    public class CustomersController : Controller
    {
        private AppContext db = new AppContext();

        // GET: Customers
        public async Task<ActionResult> Index()
        {
            return View(await db.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Name,Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(customer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customers.FindAsync(id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            PopulateAddedServiceData(customer);
            return View(customer);
        }

        private void PopulateAddedServiceData(Customer customer)
        {
            var allServices = db.Services;
            var customerServices = new HashSet<int>(customer.Services.Select(s => s.ID));
            var viewModel = new List<AddedServiceData>();
            foreach (var service in allServices)
            {
                viewModel.Add(new AddedServiceData
                {
                    ServiceID = service.ID,
                    Name = service.Name,
                    Assigned = customerServices.Contains(service.ID)
                });
            }

            ViewBag.Services = viewModel;
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Name,Address")] Customer customer, string[] selectedServices)
        {
            foreach(string service in selectedServices)
            {
                Debug.WriteLine(service);
            }

            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                UpdateCustomerServices(selectedServices, customer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            PopulateAddedServiceData(customer);
            return View(customer);
        }

        private void UpdateCustomerServices(string[] selectedServices, Customer customer)
        {
            if(selectedServices == null)
            {
                customer.Services = new List<Service>();
                return;
            }

            var selectedServiceHS = new HashSet<string>(selectedServices);
            var customerServices = new HashSet<int>
                (customer.Services.Select(s => s.ID));

            Debug.WriteLine("how many services already added? " + customerServices.Count);

            foreach(var service in db.Services)
            {
                if(selectedServiceHS.Contains(service.ID.ToString()))
                {
                    Debug.WriteLine(service.ID.ToString() + " selected");
                    if(!customerServices.Contains(service.ID))
                    {
                        Debug.WriteLine(service.ID.ToString() + " add new");
                        customer.Services.Add(service);
                    }
                }
                else
                {
                    if(customerServices.Contains(service.ID))
                    {
                        Debug.WriteLine(service.ID.ToString() + " remove");
                        customer.Services.Remove(service);
                    }
                }
            }
        }

        // GET: Customers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Customer customer = await db.Customers.FindAsync(id);
            db.People.Remove(customer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
