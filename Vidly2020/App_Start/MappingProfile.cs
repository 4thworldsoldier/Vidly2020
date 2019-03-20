﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly2020.Dtos;
using Vidly2020.Models;

namespace Vidly2020.App_Start
{
    public class MappingProfile : Profile
    {
        public  MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}