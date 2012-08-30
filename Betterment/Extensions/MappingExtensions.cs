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
            #region Domain and users
            Mapper.CreateMap(typeof(Domain), typeof(DomainViewModel));
            Mapper.CreateMap(typeof(DomainViewModel), typeof(Domain));

            Mapper.CreateMap(typeof(DomainProp), typeof(DomainPropViewModel));
            Mapper.CreateMap(typeof(DomainPropViewModel), typeof(DomainProp));

            Mapper.CreateMap(typeof(DomainPropDft), typeof(DomainPropDftViewModel));
            Mapper.CreateMap(typeof(DomainPropDftViewModel), typeof(DomainPropDft));

            Mapper.CreateMap(typeof(DomainUserProp), typeof(DomainUserPropViewModel));
            Mapper.CreateMap(typeof(DomainUserPropViewModel), typeof(DomainUserProp));

            Mapper.CreateMap(typeof(DomainUser), typeof(DomainUsersViewModel));
            Mapper.CreateMap(typeof(DomainUsersViewModel), typeof(DomainUser));
            #endregion
        }
    }
}