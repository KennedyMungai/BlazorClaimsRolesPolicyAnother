using System.ComponentModel.DataAnnotations;

namespace BlazorClaimsRolesPolicy.Data;

public class User
{
    [EmailAddress]
    [Required]
    public string? LoginName { get; set; }
    [Required]
    public string? UserRole { get; set; }
}