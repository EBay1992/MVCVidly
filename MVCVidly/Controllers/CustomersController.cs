using Microsoft.AspNetCore.Mvc;
using MVCVidly.Data;
using System.Linq;

namespace MVCVidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DataContext _dataContext;

        public CustomersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var customers = _dataContext.Customers.OrderBy(c => c.Id).Take(10);

            return View(customers);
        }
    }
}
