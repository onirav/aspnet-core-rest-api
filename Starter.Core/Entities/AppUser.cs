using Microsoft.AspNetCore.Identity;

namespace Starter.Core.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}
