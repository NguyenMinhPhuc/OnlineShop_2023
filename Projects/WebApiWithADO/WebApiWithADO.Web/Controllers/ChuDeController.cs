using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWithADO.Model.DAO;
using WebApiWithADO.Model.EF;

namespace WebApiWithADO.Web.Controllers
{
    // "api/{controller}/{id}",
    public class ChuDeController : ApiController
    {
        [HttpGet]
        public List<ChuDe> GetChuDes()
        {
            var chuDes = new ChuDeDao().GetChuDes();
            return chuDes;
        }
        [HttpGet]
        public ChuDe GetChuDe(int id)
        {
            var chuDe = new ChuDeDao().GetChuDeByID(id);
            return chuDe;
        }
        // "api/{controller}/{id}",
        [HttpPost]
        public bool InsertChuDe([FromBody] int maChuDe,string tenChuDe, string moTa)
        {
            string err = string.Empty;
            try
            {
                var result = new ChuDeDao().InsertChuDe(ref err, maChuDe, tenChuDe, moTa);
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }
        [HttpPut]
        // "api/{controller}/{id}",
        public bool UpdateChuDe([FromBody] int maChuDe, string tenChuDe, string moTa)
        {
            string err = string.Empty;
            try
            {
                var result = new ChuDeDao().UpdateChuDe(ref err, maChuDe, tenChuDe, moTa);
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }
        [HttpDelete]
        public bool DeleteChuDe(string maChuDe)
        {
            string err = string.Empty;
            try
            {
                var result = new ChuDeDao().DeleteChuDe(ref err, Convert.ToInt32(maChuDe));
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }
    }
}
