using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbData.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string movieYear { get; set; }
        public string movieLink { get; set; }
        public string movieImageUrl { get; set; }

    }
}
