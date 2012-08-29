using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;
using Betterment.Models;
using AutoMapper;

namespace Betterment
{
    public static class MappingExtensions
    {
        public static void Mapping()
        {
            Mapper.CreateMap(typeof(Domains), typeof(DomainViewModel));
            Mapper.CreateMap(typeof(DomainViewModel), typeof(Domains));
        }
    }
}