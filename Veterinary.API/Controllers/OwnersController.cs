using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinary.API.Data;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Controllers
{

    [ApiController]
    [Route("/api/owners")]
    public class OwnersController : ControllerBase
    {

        private readonly DataContext _context;

        public OwnersController(DataContext context)
        {
            _context = context;
        }


        //Método GET --- Select * From Owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {


            return Ok(await _context.Owners.ToListAsync());
        }


        //Método POST- insertar en base de datos
        [HttpPost]

        public async Task<ActionResult> Post(Owner owner)
        {

            _context.Add(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //GEt por párametro- select * from Owners where id=1
        //https://localhost:7000/api/owners/id:int?id=1
        [HttpGet("id:int")]

        public async Task<ActionResult> Get(int id)
        {

var owner = await _context.Owners.FirstOrDefaultAsync(x => x.Id == id); 
if(owner == null)
            {


                return NotFound();  //404
            }

return Ok(owner);//200


        }




        //Método PUT- actualizar datos 
        [HttpPut]

        public async Task<ActionResult> Put(Owner owner)
        {

            _context.Update(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);
        }

        //Delete - Eliminar registros

        [HttpDelete("id:int")]

        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.Owners
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();  

            if (filasafectadas == 0)
            {


                return NotFound();  //404
            }

            return NoContent();//204


        }

    }

}
