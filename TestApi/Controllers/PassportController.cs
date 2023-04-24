using MySql.Data.MySqlClient;
//using MySqlConnector;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class PassportController : ApiController
    {
        //MySqlConnection conn = new MySqlConnection("server=192.168.11.75;port=3306;username=root;password=r00tpass;");

        //[HttpGet]
        //api/<controller>
        //public string FindById(string id)
        //{
        //    conn.Open();
        //    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbl_citizen LEFT JOIN tbl_appliedpp ON tbl_citizen.Citizen_No=tbl_appliedpp.Citizen_No;", conn);

        //    da.SelectCommand.CommandType = CommandType.Text;

        //    DataTable dt = new DataTable();

        //    da.Fill(dt);

        //    if (dt.Rows.Count > 0)
        //    {
        //        return JsonConvert.SerializeObject(dt);
        //    }
        //    else
        //    {
        //        return "No data found";
        //    }
        //}
        [HttpGet]
        //api/<controller>
        public DataTable FindById(string id)
        {
            DataTable dt;
       
            string con = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(con);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT Name,Name_In_Myanmar,Date_Of_Birth,NrcNo,tbl_appliedpp.DEO_No,Passport_No,Date_Of_Issue,Date_Of_Expiry,application_id,IssuingOffice FROM passbaseprint.tbl_citizen INNER JOIN passbaseprint.tbl_appliedpp ON tbl_citizen.Citizen_No=tbl_appliedpp.Citizen_No LEFT JOIN passbase.tblduration ON tbl_appliedpp.DEO_No=tblduration.DEO_No WHERE tbl_appliedpp.Passport_No= @passno", conn))
            {               
                cmd.Parameters.AddWithValue("@passno", id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }

    }
}
