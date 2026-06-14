using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TarGestAPI.Application.DTO;
using TarGestAPI.Domain.Entities;
using TarGestAPI.Infrastructure.Context;

namespace TarGest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public readonly DbContextApi _context;
        public TaskController(DbContextApi context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult> AddTaks([FromBody] TaskDTO dto)
        {
            var task = new Tasks()
            {
                descriptionTask = dto.descriptionTask,
                titleTask=dto.titleTask,
                timeStartTask=dto.timeStartTask
            }; 
            await _context.AddAsync(task);
            await _context.SaveChangesAsync();
            return Created();
        }  
       
    }
}
