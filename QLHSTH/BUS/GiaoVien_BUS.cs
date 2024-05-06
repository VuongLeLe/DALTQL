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
    public class GiaoVien_BUS
    {
        public static List<GiaoVien_DTO> LayGiaoVien()
        {
            return GiaoVien_DAO.LayGiaoVien();
        }
        public static bool ThemGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.ThemGiaoVien(gv);
        }
        public static GiaoVien_DTO TimGiaoVienTheoMa(string ma)
        {
            return GiaoVien_DAO.TimGiaoVienTheoMa(ma);
        }
        // Tìm giáo viên theo tên
        public static List<GiaoVien_DTO> TimGiaoVienTheoTen(string ten)
        {
            return GiaoVien_DAO.TimGiaoVienTheoTen(ten);
        }


        public static List<GiaoVien_DTO> TimGiaoVienTheoHo(string ho)
        {
            return GiaoVien_DAO.TimGiaoVienTheoHo(ho);
        }
        //sua gv
        public static bool SuaGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.SuaGiaoVien(gv);
        }

        //xoa gv
        public static bool XoaGiaoVien(GiaoVien_DTO gv)
        {
            return GiaoVien_DAO.XoaGiaoVien(gv);
        }
    }
}

