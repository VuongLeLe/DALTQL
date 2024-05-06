using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc_DTO
    {
        private string sMaLop;
        public string SMaLop
        {
            get { return sMaLop; }
            set { sMaLop = value; }
        }
        private string sTenLop;
        public string STenLop
        {
            get { return sTenLop; }
            set { sTenLop = value; }
        }
        private string sMaGV;
        public string SMaGV
        {
            get { return sMaGV; }
            set { sMaGV = value; }
        }
    }

}
