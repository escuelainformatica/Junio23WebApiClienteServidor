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

        [Route("Ping")]
        public object Ping(string pong)
        {
            // object = tipo de dato generico.

            try { 
                
                int n=0;
                if (pong == "")
                {
                    int n2 = n / n;
                }
                    
            } catch(Exception ex)
            {
                var mensaje=new { code=2,message=ex.Message}; // objeto sin clase.
                return mensaje;
            }

            return pong;
        }

    }
}
