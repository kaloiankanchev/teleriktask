using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using TelerikThomas.Models;
using Kendo.Mvc.Extensions;
using TelerikThomas.Data;
using Microsoft.EntityFrameworkCore;

namespace TelerikThomas.Controllers
{
    public class GridController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GridController(ApplicationDbContext context)
        {
            _context = context;


        }


        public ActionResult Get([DataSourceRequest]DataSourceRequest request)
        {
            var result = _context.Customers.Select(x => new Person
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Phone = x.Phone
            }).ToList();

            var dsResult = result.ToDataSourceResult(request);
            return Json(dsResult);
        }


        public ActionResult Create([DataSourceRequest]DataSourceRequest request, Person customer)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    var _emplist = _context.Customers.ToList();
                    return Json(new[] { customer }.ToDataSourceResult(request, ModelState));
                }

                else
                {
                    return Json(_context.Customers.ToList());
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }


        public ActionResult Update([DataSourceRequest]DataSourceRequest request, Person customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Entry(customer).State = EntityState.Modified;
                    _context.SaveChanges();
                    return Json(new[] { customer }.ToDataSourceResult(request, ModelState));

                }
                else
                {
                    return Json(_context.Customers.ToList());
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }


        public ActionResult Delete([DataSourceRequest]DataSourceRequest request, Person customer)
        {
            try
            {
                Person customerToDelete = _context.Customers.Find(customer.Id);
                if (customerToDelete == null)
                {
                    return Json("Employee Not Found");
                }

                _context.Customers.Remove(customerToDelete);
                _context.SaveChanges();
                return Json(_context.Customers.ToList());
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }


    }
}
