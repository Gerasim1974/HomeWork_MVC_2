using HW_WebAppl2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW_WebAppl2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //*****************************************
        public string GetDogCardData(DogViewModel dogModel)
        {
            foreach (var item in Request.Query)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            return $"Собака: {dogModel._nikname}, возраст: {dogModel._ageDog}, вес: {dogModel._dogWeight}, хозяин: {dogModel._dogowner}";
        }


        //public string GetPersonData(PersonViewModel person)
        //{
        //    foreach (var item in Request.Query)
        //    {
        //        Console.WriteLine($"{item.Key}:{item.Value}");
        //    }
        //    return $"Name: {person.Name}, age: {person.Age}, City: {person.City}";

        //}

        ////[HttpGet("Home/GetPerson/{id}/{Sign}")]
        //[HttpGet("Home/GetPerson/{id}&{Sign}")]
        //// [Route("Person")]
        //public PersonViewModel GetPerson(int id, string SubName)
        //{
        //    PersonViewModel person = new PersonViewModel();
        //    if (id == 0)
        //    {
        //        person.Name = "Nikita";
        //        person.Age = 30;
        //        person.City = "Minsk";
        //    }
        //    else if (id == 1)
        //    {
        //        person.Name = "Ivan";
        //        person.Age = 40;
        //        person.City = "Vologda";
        //    }
        //    return person;
        //}

        ////public string GetPersonData()
        ////{

        ////}

        //public IActionResult RedirectToGetPersonData()
        //{
        //    return RedirectToAction("GetPersonData");
        //}


        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}