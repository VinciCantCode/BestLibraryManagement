using System;
using BestLibraryManagement.ViewModels;
using BestLibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using BestLibraryManagement.Data;

namespace BestLibraryManagement.Controllers
{
    public class CustomersController : Controller
    {
        private readonly BestLibraryManagementDbContext _dbContext;

        public CustomersController(BestLibraryManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var customers = _dbContext.Customers.ToList();
            return View(customers);
        }

        [HttpPost]
        public IActionResult DeleteCustomer(string name)
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.CustomerName == name);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index", "Customers");
        }
    }
}