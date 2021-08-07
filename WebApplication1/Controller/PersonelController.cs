using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controller
{
    [Route("[controller]")]
    public class PersonelController:ControllerBase
    {
        internal IOtelService Srv1 { get; }
        internal IOtelService Srv2 { get; }

        public PersonelController(IOtelService _srv1, IOtelService _srv2)
        {
            Srv1 = _srv1;
            Srv2 = _srv2;

        }

      
        [HttpGet]
        public string Get()
        {
            return Srv1.OtelGetir();
        }
    }
}
