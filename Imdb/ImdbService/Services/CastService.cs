using ImdbData.Contexts;
using ImdbData.Models;
using ImdbData.Objects;
using ImdbData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbService.Services
{
   public class CastService
    {
        
        public int CastGenerateCastId(Star _star)
        {
            Cast castForInsert = new Cast();
            castForInsert.castLink = _star.starLink;
            castForInsert.nameSurname = _star.NameSurname;
            var castRepository = new CastRepository();
            castRepository.Insert(castForInsert);
            return castForInsert.castId;          
        }
        public int CastGenerateCastId(Writer _writer)
        {
            Cast castForInsert = new Cast();
            castForInsert.castLink = _writer.writerLink;
            castForInsert.nameSurname = _writer.NameSurname;
            var castRepository = new CastRepository();
            castRepository.Insert(castForInsert);
            return castForInsert.castId;
        }
        public int CastGenerateCastId(Director _director)
        {
            Cast castForInsert = new Cast();
            castForInsert.castLink = _director.directorLink;
            castForInsert.nameSurname = _director.NameSurname;
            var castRepository = new CastRepository();
            castRepository.Insert(castForInsert);
            return castForInsert.castId;
        }

        public Cast FindCast(string _link)
        {
            var castRepository = new CastRepository();
            Cast selectedCast = new Cast();
            selectedCast = castRepository.FindWithLink(x => x.castLink == _link);
            return selectedCast;
        }

    }
}
