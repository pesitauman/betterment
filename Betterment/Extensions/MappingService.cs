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
        #region Domain and users

        public static Domain ToEntity(this DomainViewModel model)
        {
            return Mapper.Map<DomainViewModel, Domain>(model);
        }

        public static DomainViewModel ToModel(this Domain entity)
        {
            return Mapper.Map<Domain, DomainViewModel>(entity);
        }


        public static DomainProp ToEntity(this DomainPropViewModel model)
        {
            return Mapper.Map<DomainPropViewModel, DomainProp>(model);
        }

        public static DomainPropViewModel ToModel(this DomainProp entity)
        {
            return Mapper.Map<DomainProp, DomainPropViewModel>(entity);
        }


        public static DomainPropDft ToEntity(this DomainPropDftViewModel model)
        {
            return Mapper.Map<DomainPropDftViewModel, DomainPropDft>(model);
        }

        public static DomainPropDftViewModel ToModel(this DomainPropDft entity)
        {
            return Mapper.Map<DomainPropDft, DomainPropDftViewModel>(entity);
        }


        public static DomainUserProp ToEntity(this DomainUserPropViewModel model)
        {
            return Mapper.Map<DomainUserPropViewModel, DomainUserProp>(model);
        }

        public static DomainUserPropViewModel ToModel(this DomainUserProp entity)
        {
            return Mapper.Map<DomainUserProp, DomainUserPropViewModel>(entity);
        }


        public static DomainUser ToEntity(this DomainUsersViewModel model)
        {
            return Mapper.Map<DomainUsersViewModel, DomainUser>(model);
        }

        public static DomainUsersViewModel ToModel(this DomainUser entity)
        {
            return Mapper.Map<DomainUser, DomainUsersViewModel>(entity);
        }

        //collections
        public static IList<Domain> ToEntity(this IList<DomainViewModel> model)
        {
            return Mapper.Map<IList<DomainViewModel>, IList<Domain>>(model);
        }

        public static IList<DomainViewModel> ToModel(this IList<Domain> entity)
        {
            return Mapper.Map<IList<Domain>, IList<DomainViewModel>>(entity);
        }
        #endregion
    }
}