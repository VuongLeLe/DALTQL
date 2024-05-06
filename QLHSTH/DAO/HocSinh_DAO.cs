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
    public class HocSinh_DAO
    {
        static SqlConnection con;
        public static List<HocSinh_DTO> LayHocSinh()
        {
            string sTruyVan = "select * from hocsinh order by mahs asc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinh_DTO> lstHocSinh = new List<HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.SMaHS = dt.Rows[i]["mahs"].ToString();
                hs.SHoLotHS = dt.Rows[i]["holot"].ToString();
                hs.STenHS = dt.Rows[i]["tenhs"].ToString();
                hs.SPhaiHS = dt.Rows[i]["phai"].ToString();               
                hs.DTNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                hs.SSDTHS = dt.Rows[i]["SDT"].ToString();
                hs.SHP = dt.Rows[i]["hocphi"].ToString();
                hs.SMaLop = dt.Rows[i]["malop"].ToString();

                lstHocSinh.Add(hs);
            }
            return lstHocSinh;
        }

        public static bool ThemHocSinh(HocSinh_DTO hs)
        {

            string sTruyVan = string.Format(@"insert into hocsinh(holot,tenhs,phai,ngaysinh,SDT,hocphi,malop) values (N'{0}',
            N'{1}',N'{2}',N'{3}','{4}','{5}','{6}')", hs.SHoLotHS, hs.STenHS, hs.SPhaiHS, hs.DTNgaySinh.ToString("yyyy-MM-dd"), hs.SSDTHS, hs.SHP, hs.SMaLop);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin HocSinh có mã , trả về null nếu không thấy
        public static HocSinh_DTO TimHocSinhTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where mahs=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HocSinh_DTO hs = new HocSinh_DTO();
            hs.SMaHS = dt.Rows[0]["mahs"].ToString();
            hs.SHoLotHS = dt.Rows[0]["holot"].ToString();
            hs.STenHS = dt.Rows[0]["tenhs"].ToString();
            hs.SPhaiHS = dt.Rows[0]["phai"].ToString();
            hs.DTNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            hs.SSDTHS = dt.Rows[0]["SDT"].ToString();
            hs.SHP = dt.Rows[0]["hocphi"].ToString();
            hs.SMaLop = dt.Rows[0]["malop"].ToString();
            DataProvider.DongKetNoi(con);
            return hs;
        }
        // Tìm HocSinh theo tên, trả về null nếu không thấy
        public static List<HocSinh_DTO> TimHocSinhTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where tenhs like 
N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinh_DTO> lstHocSinh = new List<DTO.HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.SMaHS = dt.Rows[i]["mahs"].ToString();
                hs.SHoLotHS = dt.Rows[i]["holot"].ToString();
                hs.STenHS = dt.Rows[i]["tenhs"].ToString();
                hs.SPhaiHS = dt.Rows[i]["phai"].ToString();
                hs.DTNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                hs.SSDTHS = dt.Rows[i]["SDT"].ToString();
                hs.SHP = dt.Rows[i]["hocphi"].ToString();
                hs.SMaLop = dt.Rows[i]["malop"].ToString();
                lstHocSinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lstHocSinh;
        }

        public static List<HocSinh_DTO> TimHocSinhTheoHo(string ho)
        {
            string sTruyVan = string.Format(@"select * from hocsinh where holot like 
N'%{0}%'", ho);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinh_DTO> lstHocSinh = new List<DTO.HocSinh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinh_DTO hs = new HocSinh_DTO();
                hs.SMaHS = dt.Rows[i]["mahs"].ToString();
                hs.SHoLotHS = dt.Rows[i]["holot"].ToString();
                hs.STenHS = dt.Rows[i]["tenhs"].ToString();
                hs.SPhaiHS = dt.Rows[i]["phai"].ToString();
                hs.DTNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                hs.SSDTHS = dt.Rows[i]["SDT"].ToString();
                hs.SHP = dt.Rows[i]["hocphi"].ToString();
                hs.SMaLop = dt.Rows[i]["malop"].ToString();
                lstHocSinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lstHocSinh;
        }

        public static bool SuaHocSinh(HocSinh_DTO hs)
        {
            string sTruyVan = string.Format(@"update hocsinh set holot= N'{0}', tenhs= N'{1}',  phai= N'{2}', ngaysinh='{3}',SDT=N'{4}',  hocphi= N'{5}',malop= N'{6}' where mahs=N'{7}'", hs.SHoLotHS, hs.STenHS, hs.SPhaiHS, hs.DTNgaySinh.ToString("yyyy-MM-dd"), hs.SSDTHS, hs.SHP, hs.SMaLop, hs.SMaHS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static bool XoaHocSinh(HocSinh_DTO hs)
        {
            string sTruyVan = string.Format(@"delete from hocsinh where mahs=N'{0}'", hs.SMaHS);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

    }
}
