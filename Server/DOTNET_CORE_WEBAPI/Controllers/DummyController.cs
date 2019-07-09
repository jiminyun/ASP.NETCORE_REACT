using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_CORE_WEBAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_CORE_WEBAPI.Controllers
{
    public class DummyController : Controller
    {
        private CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]

        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}