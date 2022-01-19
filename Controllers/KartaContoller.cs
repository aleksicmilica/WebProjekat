using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace bioskop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KartaController : ControllerBase
    {
        public BioskopContext Context{get;set;}

        public KartaController(BioskopContext context){
            Context=context;
        }

      [Route("KupiKartu/{idBioskopa}/{imeFilma}/{datum}/{Red}/{BrojURedu}/{korisnickoIme}")]
      [HttpPost]
        public async Task<ActionResult> DodajKartu(int idBioskopa,string imeFilma,string datum,int Red,int BrojURedu,string korisnickoIme){

            if(idBioskopa<0){
                return BadRequest("Nije unet bioskop");
              
            }
            if (string.IsNullOrEmpty(imeFilma))
            {
                return BadRequest("Nije unet naziv filma");
                
            }
            if (string.IsNullOrEmpty(datum))
            {
                return BadRequest("Nije unet  datum projekcije");
                
            }
            if(Red == 0)
              {
                    return BadRequest("Zaboravili ste da unesete red");
              }  
            if(BrojURedu == 0)
              {
                    return BadRequest("Zaboravili ste da unesete broj sedista");
              }  
             
            
        
            try{
                
               
                DateTime Datum= DateTime.ParseExact(datum, "yyyy-MM-dd HH:mm", null);;

                var projekcija = await Context.Projkecije.Include(p => p.film).Include(p => p.sala).Where(p => p.film.bioskop.Id ==idBioskopa 
                && p.film.naziv==imeFilma && p.vreme == Datum).FirstOrDefaultAsync();
                if(projekcija == null)
                      return BadRequest("Projekcija ne postoji");  
                
                
                
                           

               
                double cena=projekcija.film.Cena;
                Korisnik k = new Korisnik();
                if(!string.IsNullOrEmpty(korisnickoIme) )
                {
                      k=await Context.Korisnici.Where(p=>p.email == korisnickoIme).FirstOrDefaultAsync();
                     
                      if (k == null){
                        return BadRequest("Ne postoji korisnik sa korisnickim imenom");
                      }
                } 
               
                Projekcija p = projekcija;  
                 
            
                Karta karta = new Karta{
                    projekcija = projekcija,
                    sediste = new Sediste{
                       sala = projekcija.sala,
                       BrReda = Red,
                       BrSedistaURedu = BrojURedu

                    },
                    korisnik = k

                };
               
                Context.Karte.Add(karta);
               
                await Context.SaveChangesAsync();

                return Ok($"Rezervisana je karta za film {projekcija.film.naziv}, sediste u redu {Red},broj mesta {BrojURedu}, po ceni {cena}");
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
        }
       


    }
}
