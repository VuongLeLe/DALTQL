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
    public class Diem_BUS
    {
        public static List<Diem_DTO> LayDiem()
        {
            return Diem_DAO.LayDiem();
        }
        public static bool ThemDiem(Diem_DTO d)
        {
            d.STBCN = (d.SDiemHKI + (d.SDiemHKII * 2 ))/3;
            return Diem_DAO.ThemDiem(d);
        }
        public static Diem_DTO TimDiemTheoMaHS(string mahs)
        {
            return Diem_DAO.TimDiemTheoMaHS(mahs);
        }

        public static Diem_DTO TimDiemTheoMaMH(string mamh)
        {
            return Diem_DAO.TimDiemTheoMaMH(mamh);
        }

        //sua d
        public static bool SuaDiem(Diem_DTO d)
        {
            d.STBCN = (d.SDiemHKI + (d.SDiemHKII * 2)) / 3;
            return Diem_DAO.SuaDiem(d);
        }

        //xoa d
        public static bool XoaDiem(Diem_DTO d)
        {
            return Diem_DAO.XoaDiem(d);
        }
    }
}
