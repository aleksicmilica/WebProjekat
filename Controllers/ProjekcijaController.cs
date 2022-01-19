using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;
using Models;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace bioskop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjekcijaController : ControllerBase
    {
        public BioskopContext Context { get; set; }

        public ProjekcijaController(BioskopContext context)
        {
            Context = context;
        }

        //[EnableCors("CORS")]
        [EnableCors("CORS")]
        [Route("ProjekcijeZaFilm/{nazivFilma}/{idBioskopa}")]
        [HttpGet]
        public async Task<ActionResult> VratiProjekcije(string nazivFilma, int idBioskopa)
        {

            if (String.IsNullOrEmpty(nazivFilma))
            {
                return BadRequest("Zaboravili ste da unesete naziv filma");
            }
            try
            {
                return Ok(await Context.Projkecije.Include(p => p.sala)
                .Include(p => p.film).Where(p => p.film.naziv == nazivFilma && p.film.bioskop.Id == idBioskopa).ToListAsync());


            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [Route("ProjekcijaZaFilm/{idBioskopa}/{nazivFilma}/{Datum}/{Vreme}")]
        [HttpGet]
        public async Task<ActionResult> VratiProjekciju(int idBioskopa, string nazivFilma, string Datum, string Vreme)
        {


            try
            {

                string datumVreme = Datum + " " + Vreme;
                DateTime DatumVreme = DateTime.ParseExact(datumVreme, "yyyy-MM-dd HH:mm", null);
                Projekcija projekcija = await Context.Projkecije.Include(p => p.sala).Where(p => p.film.bioskop.Id == idBioskopa
                 && p.film.naziv == nazivFilma && p.vreme == DatumVreme).FirstOrDefaultAsync();


                var sedista = await Context.Karte.Include(p => p.sediste).Where(p => p.projekcija == projekcija).Select(p => new { p.sediste.BrReda, p.sediste.BrSedistaURedu }).ToListAsync();


                return Ok(sedista);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
        [Route("PromenitiProjekciju/{idBioskopa}/{nazivFilma}/{Datum1}/{Datum2}")]
        [HttpPut]
        public async Task<ActionResult> PromenitiPredmet(int idBioskopa, string nazivFilma, string Datum1, string Datum2)
        {
            if (string.IsNullOrEmpty(nazivFilma))
            {
                return BadRequest("Nije unet naziv filma");

            }
            if (string.IsNullOrEmpty(Datum1))
            {
                return BadRequest("Nije unet  datum projekcije");

            }

            if (string.IsNullOrEmpty(Datum2))
            {
                return BadRequest("Nije unet korigovani datum projekcije");

            }
            if (idBioskopa < 0)
            {
                return BadRequest("Nije unet dobar id bioskopa");
            }

            try
            {
                var v1 = DateTime.ParseExact(Datum1, "yyyy-MM-dd HH:mm", null);

                var v2 = DateTime.ParseExact(Datum2, "yyyy-MM-dd HH:mm", null);
                var film = await Context.Filmovi.Where(film => film.naziv == nazivFilma).FirstOrDefaultAsync();
                var vreme = Datum2.Split(" ");
                if (film.datumKraja.ToString("yyyy-MM-dd").CompareTo(vreme[0]) < 0 || film.datumPocetka.ToString("yyyy-MM-dd").CompareTo(vreme[0]) > 0)
                {
                    return BadRequest("Film nije dostupan tog datuma");
                }

                var p = await Context.Projkecije.Include(p => p.sala).Where(p => p.film.naziv == nazivFilma && p.film.bioskop.Id == idBioskopa
                  && p.vreme == v1).FirstOrDefaultAsync();
                if (p == null)
                    return BadRequest("Ne postoji projekcija");

                


                p.vreme = v2;

                Context.Projkecije.Update(p);

                await Context.SaveChangesAsync();
                return Ok("Uspešno izmenjena projekcija filma ");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }


}
