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
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BowlerMiddleInit { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public int BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }

        //MIGHT HAVE TO SWAP UP KEY
        [Required]
        [Key]
        public int TeamID { get; set; }
    }
}
