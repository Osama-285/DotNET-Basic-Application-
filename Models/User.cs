namespace DotNET_Basic_Application_.Models;

using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string? DisplayName { get; set; }
    public DateTime LastLoginDateTime { get; set; }
    
}