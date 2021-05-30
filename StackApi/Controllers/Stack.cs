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
        static Stack<string> stack = new Stack<string>();
     
        // GET: api/<Stack>
        [HttpGet]
        [Route("pop")]
        public IEnumerable<string> Pop()
        {
            return stack;
        }

        [HttpGet]
        [Route("peek")]
        public string Peek()
        {
            return stack.Peek();
        }
        // GET: api/<Stack>
        [HttpGet]
        [Route("size")]
        public int Size()
        {
            return stack.Count;
        }


        // POST api/<Stack>
        [HttpPost]

        public ActionResult<IEnumerable<string>> Push([FromBody] string value)
        {
            stack.Push(value);
            return CreatedAtAction(nameof(Pop), stack);

        }


    }
}
