using AutoMapper;
using MyPeoject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Role, RoleDTO>().ReverseMap();
        }
    }
}
