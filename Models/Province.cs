using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using COMP3973_lab4_A01045801_Michael_Green.Models;

namespace COMP3973_lab4_A01045801_Michael_Green.Models{
  public class Province {
      [Key]
      [Display (Name="Province Code")]
      [MaxLength(2)]
      public string ProvinceCode { get; set; } 

      [Display (Name="Province Name")]
      [MaxLength(30)]
      public string ProvinceName { get; set; }

      [Display (Name="Cities")]
      public List<City> Cities { get; set; }
   } 
}
