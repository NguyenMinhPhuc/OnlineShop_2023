using OnlineShop.Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.DAO
{
    public class ChuDeDao
    {
        OnlineShopDbContext _db;
        public ChuDeDao()
        {
            _db = new OnlineShopDbContext();
        }

        public IEnumerable<ChuDe> GetAll()
        {
            return _db.Database.SqlQuery<ChuDe>("PSP_ChuDe_SelectCbo").ToList();
        }
    }
}
