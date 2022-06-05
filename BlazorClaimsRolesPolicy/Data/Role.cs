using System.ComponentModel.DataAnnotations;

namespace BlazorClaimsRolesPolicy.Data;

public class Role
{
    public string? RoleName { get; set; } = String.Empty;
    public string? Id { get; set; } = String.Empty;
    
}