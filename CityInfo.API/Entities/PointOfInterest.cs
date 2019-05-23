using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        //Foreign key annotation not required when convention based properties exist
        //this means that because there is a city property with type and name City, and a CityId property, EF will assume the relationship
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
