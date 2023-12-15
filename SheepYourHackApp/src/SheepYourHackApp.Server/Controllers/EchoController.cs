using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Controllers
{
    [ApiController]
    [Route("/api")]
    public class EchoController : Controller
    {
        private readonly IMapper _mapper;

        public EchoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("echo")]
        public async Task<IActionResult> Echo()
        {
            return Ok();
        }

        [HttpGet("mapper")]
        public async Task<IActionResult> AutomapperTest()
        {
            var test = new Test();
            test.Id = 1;
            test.Name = "test";
            test.Description = "test";

            var testDto = _mapper.Map<TestDto>(test);


            return Ok(testDto);
        }
    }


    //Klasa bazowa
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }


    //Jej dto, połączone są w helper
    public class TestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
