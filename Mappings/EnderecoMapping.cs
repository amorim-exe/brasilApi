using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping ()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}