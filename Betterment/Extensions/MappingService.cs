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

        public static Domains ToEntity(this DomainViewModel model)
        {
            return Mapper.Map<DomainViewModel, Domains>(model);
        }

        public static DomainViewModel ToModel(this Domains entity)
        {
            return Mapper.Map<Domains, DomainViewModel>(entity);
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


        public static DomainUsers ToEntity(this DomainUsersViewModel model)
        {
            return Mapper.Map<DomainUsersViewModel, DomainUsers>(model);
        }

        public static DomainUsersViewModel ToModel(this DomainUsers entity)
        {
            return Mapper.Map<DomainUsers, DomainUsersViewModel>(entity);
        }

        //collections
        public static IList<Domains> ToEntity(this IList<DomainViewModel> model)
        {
            return Mapper.Map<IList<DomainViewModel>, IList<Domains>>(model);
        }

        public static IList<DomainViewModel> ToModel(this IList<Domains> entity)
        {
            return Mapper.Map<IList<Domains>, IList<DomainViewModel>>(entity);
        }
        #endregion
    }
}