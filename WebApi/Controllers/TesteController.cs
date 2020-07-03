using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Services;

namespace WebApi.Controllers
{
    [RoutePrefix("Teste")]
    public class TesteController : ApiController
    {
        private readonly CalculaJurosService _jurosService;

        public TesteController()
        {
            _jurosService = new CalculaJurosService();
        }

        [Route("taxaJuros"), HttpGet]
        public Tuple<string, string> taxaJuros()
        {
            Tuple<string, string> result = new Tuple<string, string>(
                string.Format("{0}%", 1),
                string.Format("{0:0.00}", 0.01)
                );

            return result;
            //return string.Format("{0:0.00}", 0.01);
        }
        [Route("calculajuros"), HttpGet]
        public string calulaJuros(double valorinicial, int meses)
        {
            return _jurosService.calcularJuros1(valorinicial, meses);
        }

        [Route("showmethecode"), HttpGet]
        public string ShowMeTheCode()
        {
            return "https://github.com/CTrigger/ModeloWebApi";
        }

    }
}
