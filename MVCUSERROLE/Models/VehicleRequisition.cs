using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCUSERROLE.Models
{
    public class VehicleRequisition
    {
        [Required(ErrorMessage = "Please Slect Vechicle Type")]
        [DisplayName("Type of Vechicle")]        
        public string Typeofvechicle { get; set; }


        [Required]
        [DisplayName("Number of vechicle")]
        public int Numberofvechicle { get; set; }

        [Required]
        [DisplayName("From date")]        
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Fromdate { get; set; }


        [Required]
        [DisplayName("To date")]
        
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Todate { get; set; }



        [Required]
        [DisplayName("Report Date of vechicle")]
        
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Reportdateofvechicle { get; set; }


        [Required]
        [DisplayName("Report Time of vechicle")]
        
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> Reporttimeofvechicle { get; set; }

        [Required]
        public Nullable<System.DateTime> Location { get; set; }


        public string Place { get; set; }

        [Required]
        [DisplayName("User Name")]

        
        public string UserName { get; set; }

        [Required]
        [DisplayName("User Address")]
        public string UserAddress { get; set; }

        [Required]
        [DisplayName("Purpose")]
       
        public string Purpose { get; set; }

        [Required]
        [DisplayName("Applier Name")]
       
        public string ApplierName { get; set; }

        [Required]
        [DisplayName("Reference Details ")]
        
        public string referencedetails { get; set; }
    }
}