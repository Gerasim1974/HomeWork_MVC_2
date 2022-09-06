using Microsoft.AspNetCore.Mvc;
using HW_WebAppl2.Models;

namespace HW_WebAppl2.Controllers
{
    public class DogViewController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult VetApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VetApplication(DogViewModel myDogCard)
        {
            Console.WriteLine($"Собака: {myDogCard._nikname}, Возраст: {myDogCard._ageDog}, Вес: {myDogCard._dogWeight}, Хозяин: {myDogCard._dogowner}");
            ModelState.Clear(); 
            return VetApplication();
        }
    }
}
