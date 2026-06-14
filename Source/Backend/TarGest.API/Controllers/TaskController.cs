using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarGestAPI.Infrastructure.Context;

namespace TarGest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DbContextApi _context;
        public TaskController( DbContextApi context)
        {
            _context=context;

        }

        
    }
}
