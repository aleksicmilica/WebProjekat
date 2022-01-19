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
    public class BioskopController : ControllerBase
    {
        public BioskopContext Context{get;set;}

        public BioskopController(BioskopContext context){
            Context=context;
        }

      [Route("Bioskopi")]
      [HttpGet]
        public async Task<ActionResult> VratiBioskope(){
   
            try{
                
                return Ok(await Context.Bioskopi.Select(p => new {p.Naziv, p.Id}).ToListAsync());
            }
            catch(Exception e){
                return BadRequest(e.Message);
            }
            
        }
    

    }
}
