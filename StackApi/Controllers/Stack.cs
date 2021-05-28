using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StackApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Stack : ControllerBase
    {
        Stack<string> stack = new Stack<string>();
        
        public Stack()
        {
            stack.Push("Hello,");
            stack.Push("world");
        }
        // GET: api/<Stack>
        [HttpGet]
        public IEnumerable<string> Pop()
        {
            return stack;
        }

      

        // POST api/<Stack>
        [HttpPost]
        public ActionResult<IEnumerable<string>> Push([FromBody] string value)
        {
            stack.Push("hgfy");
            return CreatedAtAction(nameof(Pop), stack);

        }
    

    }
}
