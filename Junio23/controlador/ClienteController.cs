using Junio23.modelo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace Junio23.controlador
{
    public class ClienteController : Controller
    {
        public async Task<IActionResult> Index()
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("https://mindicador.cl/api/uf");

            string msg = await stringTask; // detiene la ejecucion.
            var uf = JsonSerializer.Deserialize<UF>(msg);

   


            return View(uf);
        }
    }
}
