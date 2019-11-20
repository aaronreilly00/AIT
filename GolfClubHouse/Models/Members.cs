using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace GolfClubHouse.Models
{
    public class Members
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

    }
}