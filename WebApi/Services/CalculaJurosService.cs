using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Services
{
    public class CalculaJurosService
    {
        public string calcularJuros1(double valorinicial, int meses)
        {
            double result = valorinicial * Math.Pow(1.01, meses);
            return string.Format(new CultureInfo("pt-BR"), "{0:0.00}",result);
        }
    }
}