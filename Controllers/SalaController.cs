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
    public class SalaController : ControllerBase
    {
        public BioskopContext Context{get;set;}

        public SalaController(BioskopContext context){
            Context=context;
        }

      [Route("Sala/{idBioskopa}/{nazivFilma}/{Datum}/{Vreme}")]
      [HttpGet]
        public async Task<ActionResult> VratiSalu(int idBioskopa,string nazivFilma,string Datum,string Vreme){
   
            try{
                string datumVreme=Datum+" "+Vreme;
                DateTime DatumVreme=DateTime.ParseExact(datumVreme, "yyyy-MM-dd HH:mm",null);
                
                return Ok(await Context.Projkecije.Where(p => p.film.bioskop.Id==idBioskopa &&
                p.film.naziv==nazivFilma && p.vreme==DatumVreme).Select(p => new {p.sala.BrRedova, p.sala.BrSedistaPoRedu}).ToListAsync());
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
    

    }
}
