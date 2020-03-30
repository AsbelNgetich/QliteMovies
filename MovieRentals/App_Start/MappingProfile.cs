using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieRentals.Models;
using MovieRentals.Dtos;

namespace MovieRentals.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();


            //    Mapper.CreateMap<CustomerDto, Customer>();


            //Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                  .ForMember(c => c.Id, opt => opt.Ignore());

           


        }


    }
}