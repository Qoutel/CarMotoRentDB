using System.ComponentModel.DataAnnotations;

namespace CarMotoRentDB.Models
{
    public class RentHistory
    {
        public int Id { get; set; }
        public User Customer { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime RentStartDay { get; set; }
        public DateTime RentEndDay { get; set; }
        public decimal RentAmount { get; set; }
    }
}
