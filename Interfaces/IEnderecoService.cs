using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilAPI.Dtos;

namespace BrasilAPI.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}