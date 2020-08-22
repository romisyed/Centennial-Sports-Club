using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    public class Players
    {
        [Key]
        public int PlayerId { get; set; }
        public string Playername { get; set; }
        public int cId { get; set; }
        public Clubs Club { get; set; }

    }
}
