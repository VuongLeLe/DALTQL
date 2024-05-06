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
    public class MonHoc_BUS
    {
        public static List<MonHoc_DTO> LayMonHoc()
        {
            return MonHoc_DAO.LayMonHoc();
        }
    }
}
