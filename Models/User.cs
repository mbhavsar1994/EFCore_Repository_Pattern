using System.ComponentModel.DataAnnotations;

namespace PocketBook.Models;

public class User
{
    public Guid Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string Email { get; set; }

}
