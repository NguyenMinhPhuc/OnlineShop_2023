using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiWithADO.Model.EF;

namespace WebApiWithADO.Model.DAO
{
   public class ChuDeDao
    {
        //field
       private Database db;
        //Contructor -ham tao
        public ChuDeDao()
        {
           db = new Database();
        }

        //Method
        //1. Select
        public List<ChuDe> GetChuDes()
        {
            string err = string.Empty;
            DataTable dataTable = new DataTable();
            dataTable = db.GetDataTable(ref err, "PSP_ChuDe_Select", CommandType.StoredProcedure, null);
            List<ChuDe> chuDes = new List<ChuDe>();
            foreach (DataRow dr in dataTable.Rows)
            {
                ChuDe chuDe = new ChuDe()
                {
                    MaChuDe = Convert.ToInt32(dr["MaChuDe"].ToString()),
                    TenChuDe = dr["TenChuDe"].ToString(),
                    MoTa=dr["MoTa"].ToString(),
                    IsDelete=Convert.ToBoolean(dr["IsDelete"].ToString())
                };
                chuDes.Add(chuDe);
            }
            return chuDes;
        }

        public ChuDe GetChuDeByID(int id)
        {
            string err = string.Empty;
            DataTable dataTable = new DataTable();
            dataTable = db.GetDataTable(ref err, "PSP_ChuDe_Select", CommandType.StoredProcedure, new System.Data.SqlClient.SqlParameter("@MaChuDe",id));
            ChuDe chuDe = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                chuDe = new ChuDe()
                {
                    MaChuDe = Convert.ToInt32(dr["MaChuDe"].ToString()),
                    TenChuDe = dr["TenChuDe"].ToString(),
                    MoTa = dr["MoTa"].ToString(),
                    IsDelete = Convert.ToBoolean(dr["IsDelete"].ToString())
                };
                
            }
            return chuDe;
        }
        //2. Insert

        //3. Update

        //4. Delete

    }
}
