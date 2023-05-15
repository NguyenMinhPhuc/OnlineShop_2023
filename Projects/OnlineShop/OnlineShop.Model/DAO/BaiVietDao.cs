using OnlineShop.Model.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.DAO
{
    public class BaiVietDao
    {
        OnlineShopDbContext _db;
        public BaiVietDao()
        {
            _db = new OnlineShopDbContext();
        }

        public IEnumerable<BaiViet> GetAll(int maBaiViet)
        {
            return _db.Database.SqlQuery<BaiViet>("PSP_BaiViet_Select @MaBaiViet", new SqlParameter("@MaBaiViet", maBaiViet)).ToList();
        }
    }
}
