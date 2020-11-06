using AutoMapper;
using DapperInCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperInCore.Services
{
    public class AutoMapperprofile :Profile
    {
        public AutoMapperprofile()
        {
            CreateMap<StudentDTO,Student>();

            CreateMap<AddressDTO,Address>();
        }
    }
}
