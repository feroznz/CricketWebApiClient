using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiClient.Models
{
    public class PlayerModel
    {

        //public int PlayerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string Age { get; set; }

        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]

        public string ProfileUrl { get; set; }
        public string ImageUrl { get; set; }
        public string SpecialRole { get; set; }
        public string Role { get; set; }

       
        public string Batting { get; set; }
        public string Bowling { get; set; }


        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        } //


    }
}