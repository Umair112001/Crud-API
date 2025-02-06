using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        static List<Students> std = new List<Students>();

        // GET: Student
        [HttpGet]

        public IEnumerable<Students> Get()
        {
            return std;
        }

        [HttpGet("id")]
        public Students Get(int id)
        {
            return std.FirstOrDefault(s => s.Id == id);
        }


        [HttpPost]
        public void Post([FromBody] Students value)
        {
            std.Add(value);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Students value)
        {
            int i = std.FindIndex(s => s.Id == id);
            if(i>=0)
                std[i]= value; 
        }
        [HttpDelete("id")]
        public void Delete (int id)
        {
            std.RemoveAll(std => std.Id == id);
        }


    }
}
