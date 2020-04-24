using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeHelp.Cloud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbHelpController : ControllerBase
    {
        [HttpGet]
        public void GenerateTable()
        { 
        
        }
    }
}