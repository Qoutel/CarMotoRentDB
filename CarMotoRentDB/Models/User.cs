using Microsoft.AspNetCore.Identity;
namespace CarMotoRentDB.Models
{
    public class User: IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Adress { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public List<Rent>? CurrentRents { get; set; }
    }
}
