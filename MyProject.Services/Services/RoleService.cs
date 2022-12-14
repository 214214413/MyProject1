using AutoMapper;
using MyPeoject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
   public class RoleService: IRoleService
    {

        private readonly IRoleService _roleRepository;
        private readonly IMapper _mapper;


        public RoleService(IRoleService context,IMapper mapper)
            {
            _roleRepository = context;
            _mapper=mapper;
            }

        public RoleDTO Add(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Add(id,name,description));
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public List<RoleDTO> GetAll()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepository.GetAll());
        }

        public RoleDTO GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.GetById(id));
        }

        public RoleDTO Update(RoleDTO role)
        {
            return _mapper.Map<RoleDTO>(_roleRepository.Update(role));
        }

      
    }
    }

