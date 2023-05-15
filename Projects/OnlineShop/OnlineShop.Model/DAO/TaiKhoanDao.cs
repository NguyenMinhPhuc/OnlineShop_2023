using OnlineShop.Model.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.DAO
{
    public class TaiKhoanDao
    {
        OnlineShopDbContext _db;
        public TaiKhoanDao()
        {
            _db = new OnlineShopDbContext();
        }

        //Viết phương thức kiểm tra kết nối
        public bool KiemTraTaiKhoan(string tenTaiKhoan, string matKhau)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TenTaiKhoan",tenTaiKhoan),
                new SqlParameter("@MatKhau",matKhau)
            };

            return _db.Database.SqlQuery<bool>("PSP_TaiKhoan_CheckLogin @TenTaiKhoan,@MatKhau", sqlParameters).SingleOrDefault();
        }
    }
}
