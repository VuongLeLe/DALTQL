using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class HocSinh_BUS
    {
        public static List<HocSinh_DTO> LayHocSinh()
        {
            return HocSinh_DAO.LayHocSinh();
        }
        public static bool ThemHocSinh(HocSinh_DTO hs)
        {
            return HocSinh_DAO.ThemHocSinh(hs);
        }
        public static HocSinh_DTO TimHocSinhTheoMa(string ma)
        {
            return HocSinh_DAO.TimHocSinhTheoMa(ma);
        }
        // Tìm HocSinh theo tên
        public static List<HocSinh_DTO> TimHocSinhTheoTen(string ten)
        {
            return HocSinh_DAO.TimHocSinhTheoTen(ten);
        }


        public static List<HocSinh_DTO> TimHocSinhTheoHo(string ho)
        {
            return HocSinh_DAO.TimHocSinhTheoHo(ho);
        }
        //sua hs
        public static bool SuaHocSinh(HocSinh_DTO hs)
        {
            return HocSinh_DAO.SuaHocSinh(hs);
        }

        //xoa hs
        public static bool XoaHocSinh(HocSinh_DTO hs)
        {
            return HocSinh_DAO.XoaHocSinh(hs);
        }
    }
}

