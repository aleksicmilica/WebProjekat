using System.ComponentModel.DataAnnotations;
using System;
namespace Models{
    public class Film{
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]        
        public string naziv {get; set;}
        [Required]
        [MaxLength(50)]
 
        public string zanr{get; set;}
 
 
        [Required]
      
        public DateTime  datumPocetka{get; set;}
                     
        [Required]
 
        public DateTime  datumKraja{get; set;}

       
        [Required]
        public int Cena{get; set;}

        
        [Required]
        public Bioskop bioskop{get; set;}

    }
}