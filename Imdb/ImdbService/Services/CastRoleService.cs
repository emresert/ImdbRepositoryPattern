using ImdbData.Models;
using ImdbData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbService.Services
{
    public class CastRoleService 
    {
        public int CastRoleGenerateCastRoleId(string castRoleType)
        {   
            CastRole _castRole = new CastRole();
            _castRole.castRoleName = castRoleType;
            var castRoleRepository = new CastRoleRepository();
            castRoleRepository.Insert(_castRole);
            return _castRole.castRoleId;
        }
        public CastRole FindCastRole(string role)
        {
            var castRepository = new CastRoleRepository();
            CastRole selectedMovie = new CastRole();
            selectedMovie = castRepository.FindWithRole(x => x.castRoleName == role);
            return selectedMovie;
        }
    }
}
