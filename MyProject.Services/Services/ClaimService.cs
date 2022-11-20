
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
   public class ClaimService: IClaimeService
    {

        private readonly IClaimeService _claimService;
        private readonly IMapper _mapper;


        public ClaimService(IClaimeService context, IMapper mapper)
        {
            _claimService = context;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicyDTO ePolicy)
        {
            return _mapper.Map<ClaimDTO>(Add(id, roleId,permissionId,ePolicy));

        }

        public void Delete(int id)
        {
            _claimService.Delete(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<ClaimDTO>(Add(id, roleId, permissionId, ePolicy));
        }

        public ClaimDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            throw new NotImplementedException();
        }

        //public Claim Add(int id, int roleId, int permissionId, EPolicy ePolicy)
        //{
        //    Claim c = new Claim() { Id = id, RoleId = roleId, PermissionId = permissionId, Policy = ePolicy };
        //    _context.Claims.Add(c);
        //    return c;
        //}



        //public void Delete(int id)
        //{
        //    _context.Claims.Remove(GetById(id));
        //}

        //public List<Claim> GetAll()
        //{
        //    return _context.Claims;
        //}

        //public Claim GetById(int id)
        //{
        //    return _context.Claims.Find(r => r.Id == id);
        //}

        //public Claim Update(Claim claim)
        //{
        //    Claim c1 = GetById(claim.Id);
        //    c1.RoleId = claim.RoleId;
        //    c1.PermissionId = claim.PermissionId;
        //    c1.Policy = claim.Policy;
        //    return c1;
        //}
    }
}

