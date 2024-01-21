using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrasilAPI.Dtos
{
    public class EnderecoResponse
    {
        public string? Cep {get; set;}

        public string? Estado {get; set;}

        public string? Cidade {get; set;}

        public string? Regiao {get; set;}

        public string? Rua {get; set;}

        [JsonIgnore]
        public string? Servico;
    }
}