using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingRoster.Models
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }

        [Required(ErrorMessage = "Last Name is Required: ")]
        [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        public string BowlerLastName { get; set; }

        [Required(ErrorMessage = "First Name is Required: ")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        public string BowlerFirstName { get; set; }

        [StringLength(1, ErrorMessage = "Middle Initial cannot be longer than 1 character")]
        public string BowlerMiddleInit { get; set; }

        [Required(ErrorMessage = "Address is Required: ")]
        [StringLength(50, ErrorMessage = "Address cannot be longer than 50 characters")]
        public string BowlerAddress { get; set; }
        [Required(ErrorMessage = "City is Required: ")]
        [StringLength(50, ErrorMessage = "City cannot be longer than 50 characters")]
        public string BowlerCity { get; set; }

        [Required(ErrorMessage = "State is Required: ")]
        [StringLength(2, ErrorMessage = "State Abbreviation cannot be longer than 2 characters")]
        public string BowlerState { get; set; }

        [Required(ErrorMessage = "Zip is Required: ")]
        [StringLength(10, ErrorMessage = "Zip cannot be longer than 10 characters")]
        public string BowlerZip { get; set; }

        [StringLength(14, ErrorMessage = "Phone Number cannot be longer than 14 characters")]
        public string BowlerPhoneNumber { get; set; }

        [Required]
        public int TeamID { get; set; }
    }
}
