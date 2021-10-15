using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrezziWebApi.Service;

namespace Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/prezzi")]
    public class PrezziController : Controller
    {
        private readonly IPrezziRepository prezziRepository;

        public PrezziController(IPrezziRepository prezziRepository)
        {
            this.prezziRepository = prezziRepository;
        }

        [HttpGet("{Isbn}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(double))]
        public ActionResult<double> GetPrezzoLibro(string Isbn)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"***** Ottenimento prezzo libro {Isbn} *****");

            double retVal = this.prezziRepository.SelPrezzo(Isbn);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"Prezzo Articolo: {retVal}");

            return retVal;
        }
    }
}
