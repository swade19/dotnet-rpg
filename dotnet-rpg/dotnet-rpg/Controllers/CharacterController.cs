using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    // first derive from controllerBase => mvc class without view support 
    
    [ApiController]
    [Route("api[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character (),
            new Character
            {
                Id = 1,
                Name = "Sam",
                Intelligence = 9,
                Class = RpgClass.Cleric
            }
        };

        [HttpGet("GetAll")]
        public ActionResult<Character> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}
