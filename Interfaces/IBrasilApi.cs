using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);
    }
}