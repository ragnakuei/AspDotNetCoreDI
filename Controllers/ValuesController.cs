using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspDotNetCoreDi.BL;
using AspDotNetCoreDi.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreDi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueService _service;

        public ValuesController(IValueService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var result = _service.Get();
            return Ok(result);
        }
    }
}