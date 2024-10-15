using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restauarant_Reservation_BackEnd.Models
{
    public class FavoriteRestaurant
    {
        [Key]
        public int FavoriteId { get; set; }
        public virtual User? User { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
    }
}
