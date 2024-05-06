using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;

        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QLDHS(" + DateTime.Now.Day.ToString() + "_" +
                DateTime.Now.Month.ToString() + "_" +
                DateTime.Now.Year.ToString() + "_" +
                DateTime.Now.Hour.ToString() + "_" +
                DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLDHS TO DISK = N'" + sDuongDan + sTen + "'";
            con = DataProvider.MoKetNoi();

            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }

        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            string sql = string.Format(@"USE Master alter database QLDHS set offline with
rollback immediate RESTORE DATABASE QLDHS FROM DISK = N'{0}' alter database QLDHS set online", sDuongDan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
