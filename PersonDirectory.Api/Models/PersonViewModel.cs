using PersonDirectory.DTO;
using System.ComponentModel.DataAnnotations;

namespace PersonDirectory.Api.Models;

public class PersonViewModel
{
    public RegisterViewModel CreateViewModel { get; set; }
}

public class RegisterViewModel
{
    [Required(ErrorMessage = "this field is required")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "this field is required")]
    [Display(Name = "First Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "this field is required")]
    public Gender Gender { get; set; }

    [Required(ErrorMessage = "this field is required")]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "this field is required")]
    public PhoneType PhoneNumber { get; set; }

    [Required(ErrorMessage = "this field is required")]
    public string PIN { get; set; } = null!;

    [Required(ErrorMessage = "this field is required")]
    public string Address { get; set; } = null!;
}
