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
    public class LopHoc_BUS
    {
        public static List<LopHoc_DTO> LayLopHoc()
        {
            return LopHoc_DAO.LayLopHoc();
        }
        public static bool ThemLopHoc(LopHoc_DTO lh)
        {
            return LopHoc_DAO.ThemLopHoc(lh);
        }
        public static LopHoc_DTO TimLopHocTheoMa(string ma)
        {
            return LopHoc_DAO.TimLopHocTheoMa(ma);
        }
        
        
        //sua lh
        public static bool SuaLopHoc(LopHoc_DTO lh)
        {
            return LopHoc_DAO.SuaLopHoc(lh);
        }

        //xoa lh
        public static bool XoaLopHoc(LopHoc_DTO lh)
        {
            return LopHoc_DAO.XoaLopHoc(lh);
        }
    }
}
