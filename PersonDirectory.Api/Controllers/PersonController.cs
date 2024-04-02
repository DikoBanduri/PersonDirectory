using Microsoft.AspNetCore.Mvc;
using PersonDirectory.Api.Contracts;
using PersonDirectory.DTO;
using PersonDirectory.Service.Interface.IService;

namespace PersonDirectory.Api.Controllers;

[ApiController]
[Route("[controller]")]

public class PersonController : Controller
{
    private readonly IPersonService _personService;
    private IPersonService _id; 

    public IActionResult Index()
    {
        return View();
    }

    public PersonController(IPersonService personService) => _personService = personService;

    [HttpGet]
    public async Task<ActionResult<List<PersonResponse>>> GetPeople()
    {
        var person = await _personService.GetPeople();
        return View(person);
    }
}
