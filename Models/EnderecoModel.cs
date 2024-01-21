using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrasilAPI.Models
{
    public class EnderecoModel
    {
        [JsonPropertyName("cep")]
        public string? Cep {get; set;}

        [JsonPropertyName("state")]
        public string? Estado {get; set;}

        [JsonPropertyName("city")]
        public string? Cidade {get; set;}

        [JsonPropertyName("neighborhood")]
        public string? Regiao {get; set;}

        [JsonPropertyName("street")]
        public string? Rua {get; set;}

        [JsonPropertyName("service")]
        public string? Servico;
    }
}