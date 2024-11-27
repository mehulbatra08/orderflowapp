using System.ComponentModel.DataAnnotations;
namespace OrderFlowApp.Models
{
public class Order
{
    public int Id { get; set; }
 
    public string FirstName { get; set; } = string.Empty;
    public  string LastName { get; set; } = string.Empty;
    public  string Email { get; set; } = string.Empty;
    public  string Phone { get; set; } = string.Empty;
    public  string Product { get; set; } = string.Empty;
    public  string Address { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public  string AdditionalInfo { get; set; } = string.Empty;
}

}