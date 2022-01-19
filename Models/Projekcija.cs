using System.ComponentModel.DataAnnotations;
using System;
namespace Models{
    public class Projekcija{
        [Key]
        public int Id { get; set; }
        
        [Required]
 
        public Film film{get; set;}
        [Required]
 
        public DateTime vreme{get; set;}
        [Required]
 
        public Sala sala{get; set;}
    }
}