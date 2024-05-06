using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class MonHoc_DAO
    {
        static SqlConnection con;
        public static List<MonHoc_DTO> LayMonHoc()
        {
            string sTruyVan = "select * from monhoc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<MonHoc_DTO> lstMonHoc = new List<MonHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonHoc_DTO cv = new MonHoc_DTO();
                cv.SMaMH = dt.Rows[i]["mamonhoc"].ToString();
                cv.STenMH = dt.Rows[i]["tenmon"].ToString();
                lstMonHoc.Add(cv);
            }
            return lstMonHoc;
        }
    }
}
