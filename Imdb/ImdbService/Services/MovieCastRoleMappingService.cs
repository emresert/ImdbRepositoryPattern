using ImdbData.Contexts;
using ImdbData.Models;
using ImdbData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbService.Services
{
    public class MovieCastRoleMappingService 
    {
        
        public bool MovieCastRoleMappingGenareteId(int _castId, int _castRoleId, int _movieId)
        {
            MovieCastRoleMapping mcrm = new MovieCastRoleMapping
            { fkCastId = _castId, fkCastRoleId = _castRoleId, fkMovieId = _movieId };
            var MovieCastRoleMappingRepository = new MovieCastRoleMappingRepository();
            MovieCastRoleMappingRepository.Insert(mcrm);
            return true;
        }
        public bool deleteMovieCastRoleMapping(MovieCastRoleMapping _mcrm)
        {

           MovieCastRoleMapping mcrm = new MovieCastRoleMapping();
           mcrm.fkCastId = _mcrm.fkCastId;
           mcrm.fkCastRoleId = _mcrm.fkCastRoleId;
           mcrm.fkMovieId = _mcrm.fkMovieId;
           var mcrmRepository = new MovieCastRoleMappingRepository();
           mcrmRepository.Delete(mcrm);
           return true;
        }
        public IEnumerable<MovieCastRoleMapping>getMcrmList()
        {
            var _movieCastRoleMappingRepository = new MovieCastRoleMappingRepository();    
            return _movieCastRoleMappingRepository.GetList();
        }
    }
}
