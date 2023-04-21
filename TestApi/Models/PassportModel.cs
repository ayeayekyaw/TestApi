using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    [Table("tbl_appliedpp")]
    public class PassportModel
    {
        [Key]
        public int AppliedPP_ID { get; set; }
        public string Citizen_No { get; set; }
        public string DEO_No { get; set; }
        public string Occupation { get; set; }
        public string Residence { get; set; }
        public string Education { get; set; }
        public string Purpose_Of_Visit { get; set; }
        public string Apply_Country { get; set; }
        public string Voucher_No { get; set; }
        public string Photo { get; set; }
        public string Photo_Sunglass { get; set; }
        public string Signature { get; set; }
        public string Invoice_No { get; set; }
        public DateTime Invoice_Date { get; set; }
        public string Invoice_Amt { get; set; }
        public string Passport_No { get; set; }
        public string Old_Passport_No { get; set; }
        public string PP_Type { get; set; }
        public DateTime Date_Of_Issue { get; set; }
        public DateTime Date_Of_Expiry { get; set; }
        public string Returned_Place { get; set; }
        public DateTime Returned_Date { get; set; }
        public int Is_Printed { get; set; }
        public DateTime Printed_Date { get; set; }
        public int Is_Approved { get; set; }
        public DateTime Approved_Date { get; set; }
        public int Is_Issued { get; set; }
        public DateTime Issued_Date { get; set; }
        public DateTime OldPP_Issued_Date { get; set; }
        public string Issued_By { get; set; }
        public int Is_Stopped { get; set; }
        public DateTime Stopped_Date { get; set; }
        public string Stopped_Reason { get; set; }
        public int IsDeleted { get; set; }
        public int IsActived { get; set; }
        public int IsLocked { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Modified_Date { get; set; }
        public int User_ID { get; set; }
        public int Parking_ID { get; set; }
        public string Park_No { get; set; }
        public int Is_Exported { get; set; }
        public int Is_Mobile { get; set; }
        public DateTime Carrying_Date { get; set; }
        public string IssuingOffice { get; set; }
        public string division { get; set; }
        public int IsExportedMT { get; set; }
        public int IsAllowToPrint { get; set; }
    }
}