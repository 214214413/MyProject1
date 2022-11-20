using MyPeoject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
   
        public interface IClaimeService
        {
            List<ClaimDTO> GetAll();

            ClaimDTO GetById(int id);

            ClaimDTO Add(int id, int roleId, int permissionId, EPolicyDTO ePolicy);

            ClaimDTO Update(ClaimDTO claim);

            void Delete(int id);
        }
    
}
