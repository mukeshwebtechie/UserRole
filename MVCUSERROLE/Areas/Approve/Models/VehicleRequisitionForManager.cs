using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MVCUSERROLE.Areas.Approve.Models
{
    public class VehicleRequisitionForManager
    {
        [DisplayName("Type of Vechicle")]
        public string Typeofvechicle { get; set; }
        [DisplayName("Number of vechicle")]
        public int Numberofvechicle { get; set; }
        [DisplayName("From date")]
        public Nullable<System.DateTime> Fromdate { get; set; }
        [DisplayName("To date")]
        public Nullable<System.DateTime> Todate { get; set; }

        [DisplayName("Report Date of vechicle")]
        public Nullable<System.DateTime> Reportdateofvechicle { get; set; }
        [DisplayName("Report Time of vechicle")]
        public Nullable<System.DateTime> Reporttimeofvechicle { get; set; }

        public Nullable<System.DateTime> Location { get; set; }


        public string Place { get; set; }

        [DisplayName("User Name")]
        public string UserName { get; set; }
        [DisplayName("User Address")]
        public string UserAddress { get; set; }
        [DisplayName("Purpose")]
        public string Purpose { get; set; }
        [DisplayName("Applier Name")]
        public string ApplierName { get; set; }
        [DisplayName("Reference Details ")]
        public string referencedetails { get; set; }
    }
}