using Clock.Data.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clock.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAllCars _allCars;
       private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iallcars, ICarsCategory icarscategory) { 
        _allCars = iallcars;
            _allCategories = icarscategory;
            
        }
        public ViewResult List()
        {
            var cars = _allCars.Cars;


            return View(cars);
        }
    }
}
