namespace MyRazorApp.Models;

public class StaffMember
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Office { get; set; } = string.Empty;
    public string JoinedDate { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}