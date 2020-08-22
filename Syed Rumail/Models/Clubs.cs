using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Syed_Rumail.Models
{
    public class Clubs
    {
        [Key]
        public int Id { get; set; }
        public string Clubname { get; set; }
        public string Tandc { get; set; }
        public string PivacyPolicy { get; set; }
        public string Location { get; set; }
    }
}
