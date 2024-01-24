using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile: Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap(); //Converte o contrário também
            CreateMap<UserModel, UserDtoCreate>()
                .ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>()
                .ReverseMap();
        }
    }
}
