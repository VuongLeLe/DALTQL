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
    public class Diem_DAO
    {
        static SqlConnection con;
        public static List<Diem_DTO> LayDiem()
        {
            string sTruyVan = "select * from diem order by mahs asc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Diem_DTO> lstDiem = new List<Diem_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Diem_DTO d = new Diem_DTO();
                d.SMaHS = dt.Rows[i]["mahs"].ToString();
                d.SMaMH = dt.Rows[i]["mamonhoc"].ToString();
                d.SDiemGKI = float.Parse(dt.Rows[i]["diemGKI"].ToString());
                d.SDiemHKI = float.Parse(dt.Rows[i]["diemHKI"].ToString());
                d.SDiemGKII = float.Parse(dt.Rows[i]["diemGKII"].ToString());
                d.SDiemHKII = float.Parse(dt.Rows[i]["diemHKII"].ToString());
                d.STBCN = float.Parse(dt.Rows[i]["TBCN"].ToString());
                lstDiem.Add(d);
            }
            return lstDiem;
        }

        public static bool ThemDiem(Diem_DTO d)
        {
            string sTruyVan = string.Format(@"insert into diem values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", d.SMaHS, d.SMaMH,d.SDiemGKI,d.SDiemHKI,d.SDiemGKII,d.SDiemHKII,d.STBCN);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static Diem_DTO TimDiemTheoMaHS(string mahs)
        {
            string sTruyVan = string.Format(@"select * from diem where mahs=N'{0}'",
            mahs);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Diem_DTO d = new Diem_DTO();
            d.SMaHS = dt.Rows[0]["mahs"].ToString();
            d.SMaMH = dt.Rows[0]["mamonhoc"].ToString();
            d.SDiemGKI = float.Parse(dt.Rows[0]["diemGKI"].ToString());
            d.SDiemHKI = float.Parse(dt.Rows[0]["diemHKI"].ToString());
            d.SDiemGKII = float.Parse(dt.Rows[0]["diemGKII"].ToString());
            d.SDiemHKII = float.Parse(dt.Rows[0]["diemHKII"].ToString());
            d.STBCN = float.Parse(dt.Rows[0]["TBCN"].ToString());

            DataProvider.DongKetNoi(con);
            return d;
        }

        public static Diem_DTO TimDiemTheoMaMH(string mamh)
        {
            string sTruyVan = string.Format(@"select * from diem where mamonhoc=N'{0}'",
            mamh);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Diem_DTO d = new Diem_DTO();
            d.SMaHS = dt.Rows[0]["mahs"].ToString();
            d.SMaMH = dt.Rows[0]["mamonhoc"].ToString();
            d.SDiemGKI = float.Parse(dt.Rows[0]["diemGKI"].ToString());
            d.SDiemHKI = float.Parse(dt.Rows[0]["diemHKI"].ToString());
            d.SDiemGKII = float.Parse(dt.Rows[0]["diemGKII"].ToString());
            d.SDiemHKII = float.Parse(dt.Rows[0]["diemHKII"].ToString());
            d.STBCN = float.Parse(dt.Rows[0]["TBCN"].ToString());

            DataProvider.DongKetNoi(con);
            return d;
        }

        public static bool SuaDiem(Diem_DTO d)
        {
            string sTruyVan = string.Format(@"update diem set diemGKI= N'{0}', diemHKI= N'{1}', diemGKII= N'{2}', diemHKII= N'{3}', TBCN= N'{4}' where mahs=N'{5}' and mamonhoc='{6}'", d.SDiemGKI, d.SDiemHKI, d.SDiemGKII, d.SDiemHKII, d.STBCN, d.SMaHS, d.SMaMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static bool XoaDiem(Diem_DTO d)
        {
            string sTruyVan = string.Format(@"delete from diem where mahs=N'{0}' and mamonhoc='{1}'", d.SMaHS, d.SMaMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
    }
}
