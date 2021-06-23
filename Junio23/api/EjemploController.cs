using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio23.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        [Route("Resultado")]
        public string[] Resultado()
        {
            return new string[] {"hola","mundo" };
        }
        [Route("Sumar")]
        public int Sumar(int n1,int n2)
        {
            return n1+n2;
        }
        [Route("Sumar2")]
        public int Sumar2([FromBody] Calculadora calc)
        {
            return calc.N1+calc.N2;
        }


    }
}
