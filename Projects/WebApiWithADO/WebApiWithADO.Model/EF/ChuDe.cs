using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiWithADO.Model.EF
{
   public class ChuDe
    {
        //field
        int maChuDe;
        string tenChuDe, moTa;
        bool isDelete;
        //Ctrl + R + E
        public int MaChuDe { get => maChuDe; set => maChuDe = value; }
        public string TenChuDe { get => tenChuDe; set => tenChuDe = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
        //Properties
        //public int MaChuDe 
        //{ 
        //    get { return maChuDe; }
        //    set { maChuDe = value; } 
        //}
        //public int MaChuDe { get; set; }
    }
}
