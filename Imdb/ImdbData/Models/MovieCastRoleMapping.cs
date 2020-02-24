using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbData.Models
{
    [Table("MovieCastRoleMappings")]
    public class MovieCastRoleMapping
    {
        [Key, Column(Order = 1)]
        public int fkCastId { get; set; }
        [ForeignKey("fkCastId")]
        public virtual Cast Cast { get; set; }

        [Key, Column(Order = 2)]
        public int fkCastRoleId { get; set; }
        [ForeignKey("fkCastRoleId")]
        public virtual CastRole CastRole { get; set; }

        [Key, Column(Order = 3)]
        public int fkMovieId { get; set; }
        [ForeignKey("fkMovieId")]
        public virtual Movie Movie { get; set; }

    }
}
