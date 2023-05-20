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
    }
}
