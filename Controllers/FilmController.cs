using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

namespace bioskop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        public BioskopContext Context{get;set;}

        public FilmController(BioskopContext context){
            Context=context;
        }

        [Route("IzbrisiFilm/{IdBioskopa}/{nazivFilma}")]
        [HttpDelete]
        public async Task<ActionResult> izbrisatiFilm(int IdBioskopa,string nazivFilma){
            if(IdBioskopa == 0)
                return BadRequest("Nije odabran bioskop");
            if(nazivFilma==null)
                return BadRequest("Nije odabran film");
                       
            try{
               
                Film film = await Context.Filmovi.Where(p=>p.bioskop.Id==IdBioskopa && p.naziv==nazivFilma).FirstOrDefaultAsync();
                if (film == null)
                    return BadRequest($"Ne postoji film {nazivFilma}u bioskopu");

                var karte= await Context.Karte.Where(p => p.projekcija.film.bioskop.Id==IdBioskopa && p.projekcija.film.naziv==nazivFilma ).ToListAsync();
                foreach(var k in karte){
                    Context.Karte.Remove(k);
                    await Context.SaveChangesAsync();
                }
                var projekcije = await Context.Projkecije.Where( p => p.film.bioskop.Id==IdBioskopa && p.film.naziv==nazivFilma).ToListAsync();
                foreach(var p in projekcije){
                    Context.Projkecije.Remove(p);
                    await Context.SaveChangesAsync();
                }
                string imeFilma=film.naziv;
                
                Context.Filmovi.Remove(film);
                await Context.SaveChangesAsync();
                return Ok($"Uspesno izbrisan film :{imeFilma}");    
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }    

        }
        
       
        [Route("GetFilm/{idBioskopa}")]
        [HttpGet]
        public async Task<ActionResult> vratiFilmove(int idBioskopa){
            try{
                return Ok(await Context.Filmovi.Where(p => p.bioskop.Id == idBioskopa).Select(p => p.naziv).ToListAsync());
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
        
        }
       


    }
}
