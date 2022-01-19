using System.ComponentModel.DataAnnotations;
namespace Models{
    public class Bioskop{
        [Key]
        public int Id { get; set; }
        
        
        [Required]
        [MaxLength(50)]
        public string Naziv{get; set;}
    }
}