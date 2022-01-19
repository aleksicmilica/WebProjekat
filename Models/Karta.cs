using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Models{
    public class Karta{
        [Key]
        public int Id { get; set; }
      
        [Required]
 
        public Projekcija projekcija{get; set;}
      

        [Required]
 
        public Sediste sediste{get; set;}

        
        public Korisnik korisnik{get; set;}
        
        
    }
}