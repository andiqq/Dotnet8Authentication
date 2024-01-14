using Microsoft.AspNetCore.Identity;

namespace DotNet8Authentication.Models;

public class MyUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}