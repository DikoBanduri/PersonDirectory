using Microsoft.AspNetCore.Mvc;
using PersonDirectory.Api.Models;
using PersonDirectory.Service.Interface;
using PersonDirectory.Service.Interface.IService;

namespace PersonDirectory.Api.Controllers;

public class PersonController : Controller
{
    private readonly IPersonService _personService;
    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    //[HttpGet]
    //public IActionResult Index()
    //{
    //    List<PersonViewModel> model = new List<PersonViewModel>();
    //    PersonService.GetPeople().ToList().ForEach(u =>
    //    {
    //        Person person = PersonService.GetById(u.Id);
    //        PersonViewModel user = new PersonViewModel
    //        {
    //            Id = u.Id,
    //            FirstName = $"{person.FirstName}",
    //            Lastname = $"{person.Lastname}",
    //            Gender = u.Gender,
    //            BirthDate = u.BirthDate,
    //            PhoneNumber = u.PhoneNumber,
    //            PIN = u.PIN,
    //            Address = u.Address
    //        };
    //        model.Add(user);
    //    });
    //    return View(model);
    //}
}
