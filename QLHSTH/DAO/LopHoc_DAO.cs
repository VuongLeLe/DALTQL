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
    public class LopHoc_DAO
    {
        static SqlConnection con;
        public static List<LopHoc_DTO> LayLopHoc()
        {
            string sTruyVan = "select * from lop order by malop asc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LopHoc_DTO> lstLopHoc = new List<LopHoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopHoc_DTO lh = new LopHoc_DTO();
                lh.SMaLop = dt.Rows[i]["malop"].ToString();
                lh.STenLop = dt.Rows[i]["tenlop"].ToString();
                lh.SMaGV = dt.Rows[i]["magv"].ToString();
                lstLopHoc.Add(lh);
            }
            return lstLopHoc;
        }

        public static bool ThemLopHoc(LopHoc_DTO lh)
        {
            string sTruyVan = string.Format(@"insert into lop(tenlop,magv) values(N'{0}',
N'{1}')",  lh.STenLop, lh.SMaGV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static LopHoc_DTO TimLopHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from lop where malop=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LopHoc_DTO lh = new LopHoc_DTO();
            lh.SMaLop = dt.Rows[0]["malop"].ToString();
            lh.STenLop = dt.Rows[0]["tenlop"].ToString();
            lh.SMaGV = dt.Rows[0]["magv"].ToString();
            
            DataProvider.DongKetNoi(con);
            return lh;
        }

        public static bool SuaLopHoc(LopHoc_DTO lh)
        {
            string sTruyVan = string.Format(@"update lop set tenlop= N'{0}', magv= N'{1}' where malop=N'{2}'", lh.STenLop, lh.SMaGV, lh.SMaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static bool XoaLopHoc(LopHoc_DTO lh)
        {
            string sTruyVan = string.Format(@"delete from lop where malop=N'{0}'", lh.SMaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
    }
}
