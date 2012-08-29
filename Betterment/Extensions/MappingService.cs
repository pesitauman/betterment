using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;
using Betterment.Models;
using AutoMapper;

namespace Betterment.Extensions
{
    public static class MappingService
    {
        public static Domains ToEntity(this DomainViewModel model)
        {
            return Mapper.Map<DomainViewModel, Domains>(model);
        }

        public static DomainViewModel ToModel(this Domains entity)
        {
            return Mapper.Map<Domains, DomainViewModel>(entity);
        }

    }
}