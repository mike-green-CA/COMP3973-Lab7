using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using COMP3973_lab4_A01045801_Michael_Green.Models;

namespace COMP3973_lab4_A01045801_Michael_Green.Models{
    public class City {

        [Key]
        [Display (Name = "City ID")]
        public int CityID {get; set;}

        [Display (Name = "City")]
        [MaxLength(100)]
        public string CityName {get; set;}

        [Display (Name = "Population")]
        [MaxLength(8)]
        public int Population {get; set;}

        [Display (Name = "Province Code")]
        [MaxLength(2)]
        public string ProvinceCode {get; set;}

        [ForeignKey ("ProvinceCode")]
        public Province Province {get; set;}
    }
}
    
