using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrasilAPI.Dtos
{
    public class BancoResponse
    {
        public string? Ispb {get; set;}
        public string? NomeAbreviado {get; set;}
        public int? Codigo {get; set;}
        public string? NomeCompleto {get; set;}
    }
}