using AutoMapper;
using MyPeoject.Common;
using MyProject.Repositories.Entities;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class PermissionService : IPermissionService
    {


        private readonly IPermissionService _permissionService;
        private readonly IMapper _mapper;


        public PermissionService(IPermissionService context, IMapper mapper)
        {
            _permissionService = context;
            _mapper = mapper;
        }

        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(Add(id, name, description));
        }

        public void Delete(int id)
        {
           _permissionService.Delete(id);

        }

        public List<PermissionDTO> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>(GetAll());

        }

        public PermissionDTO GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(GetById(id));

        }

        public PermissionDTO Update(PermissionDTO Permission)
        {
            return _mapper.Map<PermissionDTO>(Update(Permission));

        }


        //public Permission Add(int id, string name, string description)
        //    {
        //        Permission p = new Permission() { Id = id, Name = name, Description = description };
        //        _context.Permissions.Add(p);
        //        return p;
        //    }

        //    public void Delete(int id)
        //    {
        //        _context.Permissions.Remove(GetById(id));
        //    }

        //    public List<Permission> GetAll()
        //    {
        //        return _context.Permissions;
        //    }

        //    public Permission GetById(int id)
        //    {
        //        return _context.Permissions.Find(r => r.Id == id);
        //    }

        //    public Permission Update(Permission Permission)
        //    {
        //        Permission r1 = GetById(Permission.Id);
        //        r1.Name = Permission.Name;
        //        r1.Description = Permission.Description;
        //        return r1;
        //    }
        //}
    }
}

