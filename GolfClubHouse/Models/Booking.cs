using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GolfClubHouse.Models
{
    public class Booking
    {
        [Key]
        

        [Required]
        public string time { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime DateAdded { get; set; }

        [Required]
        public int MembersId { get; set; }
        public Members Members { get; set; }

    }
}