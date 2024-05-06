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
    public class GiaoVien_DAO
    {
        static SqlConnection con;
        public static List<GiaoVien_DTO> LayGiaoVien()
        {
            string sTruyVan = "select * from giaovien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiaoVien_DTO> lstGiaoVien = new List<GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.SMaGV = dt.Rows[i]["magv"].ToString();
                gv.SHoLot = dt.Rows[i]["holot"].ToString();
                gv.STenGV = dt.Rows[i]["tengv"].ToString();
                gv.SPhai = dt.Rows[i]["phai"].ToString();
                gv.SSDT = dt.Rows[i]["SDT"].ToString();
                gv.DTNamSinh = DateTime.Parse(dt.Rows[i]["namsinh"].ToString());
                gv.SMaCV = dt.Rows[i]["macv"].ToString();
                gv.SMaMH = dt.Rows[i]["mamonhoc"].ToString();

                lstGiaoVien.Add(gv);
            }
            return lstGiaoVien;
        }

        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"insert into giaovien(holot,tengv,phai,SDT,namsinh,macv,mamonhoc) values(N'{0}',
N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}')", gv.SHoLot, gv.STenGV, gv.SPhai,gv.SSDT,gv.DTNamSinh, gv.SMaCV,gv.SMaMH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin giao viên có mã , trả về null nếu không thấy
        public static GiaoVien_DTO TimGiaoVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from giaovien where magv=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            GiaoVien_DTO gv = new GiaoVien_DTO();
            gv.SMaGV = dt.Rows[0]["magv"].ToString();
            gv.SHoLot = dt.Rows[0]["holot"].ToString();
            gv.STenGV = dt.Rows[0]["tengv"].ToString();
            gv.SPhai = dt.Rows[0]["phai"].ToString();
            gv.SSDT = dt.Rows[0]["SDT"].ToString();
            gv.DTNamSinh = DateTime.Parse(dt.Rows[0]["namsinh"].ToString());
            gv.SMaCV = dt.Rows[0]["macv"].ToString();
            gv.SMaMH = dt.Rows[0]["mamonhoc"].ToString();
            DataProvider.DongKetNoi(con);
            return gv;
        }
        // Tìm giáo viên theo tên, trả về null nếu không thấy
        public static List<GiaoVien_DTO> TimGiaoVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from giaovien where tengv like 
N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiaoVien_DTO> lstGiaoVien = new List<DTO.GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.SMaGV = dt.Rows[i]["magv"].ToString();
                gv.SHoLot = dt.Rows[i]["holot"].ToString();
                gv.STenGV = dt.Rows[i]["tengv"].ToString();
                gv.SPhai = dt.Rows[i]["phai"].ToString();
                gv.SSDT = dt.Rows[i]["SDT"].ToString();
                gv.DTNamSinh = DateTime.Parse(dt.Rows[i]["namsinh"].ToString());
                gv.SMaCV = dt.Rows[i]["macv"].ToString();
                gv.SMaMH = dt.Rows[i]["mamonhoc"].ToString();
                lstGiaoVien.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lstGiaoVien;
        }

        public static List<GiaoVien_DTO> TimGiaoVienTheoHo(string ho)
        {
            string sTruyVan = string.Format(@"select * from giaovien where holot like 
'%{0}%'", ho);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiaoVien_DTO> lstGiaoVien = new List<DTO.GiaoVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiaoVien_DTO gv = new GiaoVien_DTO();
                gv.SMaGV = dt.Rows[i]["magv"].ToString();
                gv.SHoLot = dt.Rows[i]["holot"].ToString();
                gv.STenGV = dt.Rows[i]["tengv"].ToString();
                gv.SPhai = dt.Rows[i]["phai"].ToString();
                gv.SSDT = dt.Rows[i]["SDT"].ToString();
                gv.DTNamSinh = DateTime.Parse(dt.Rows[i]["namsinh"].ToString());
                gv.SMaCV = dt.Rows[i]["macv"].ToString();
                gv.SMaMH = dt.Rows[i]["mamonhoc"].ToString();
                lstGiaoVien.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lstGiaoVien;
        }

        public static bool SuaGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"update giaovien set holot= N'{0}', tengv= N'{1}',  phai= N'{2}',SDT=N'{3}', namsinh='{4}',  macv= N'{5}',mamonhoc= N'{6}' where magv=N'{7}'", gv.SHoLot, gv.STenGV, gv.SPhai, gv.SSDT, gv.DTNamSinh, gv.SMaCV, gv.SMaMH, gv.SMaGV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static bool XoaGiaoVien(GiaoVien_DTO gv)
        {
            string sTruyVan = string.Format(@"delete from giaovien where magv=N'{0}'", gv.SMaGV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

    }
}
