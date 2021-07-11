using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebAPIEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]//http verbs are opitional
        public string GetString()
        {
            return "get string called";
        }


        [HttpPost]
        public string  PostString()
        {
            return "post string called";
        }


        [HttpPut]
        public string PutString()
        {
            return "Put string is called";
        }

        //this is demo comment
        [HttpDelete]
        public string DeleteString()
        {
            return "Delete string is called";
        }
    }
}
