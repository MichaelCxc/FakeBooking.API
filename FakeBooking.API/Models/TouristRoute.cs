using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FakeBooking.API.Models
{
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        [Range(0.0, 1.0)]
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        [MaxLength]
        public string Features { get; set; }
        [MaxLength]
        public string Fees { get; set; }
        [MaxLength]
        public string Notes { get; set; }
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; } 
            = new List<TouristRoutePicture>();

        public double? Rating { get; set; } // Optional rating field, can be null if not rated yet
        public TravelDays? TravelDays { get; set; } // Optional travel days field, can be null if not specified
        public TripType? TripType { get; set; } // Optional trip type field, can be null if not specified
        public DepartureCity? DepartureCity { get; set; } // Optional departure city field, can be null if not specified
    }
}
