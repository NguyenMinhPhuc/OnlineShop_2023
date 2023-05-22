using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWithADO.Model.EF;

namespace WebApiWithADO.Web.Controllers
{
    public class BaiVietController : ApiController
    {

        //1. Lấy bài viết
        //1.1 Lấy tất cả bài viết
       // api/{controller}/{id}
        [HttpGet]
        //api/BaiViet
        public List<BaiViet> getAllBaiViet()
        {
            List<BaiViet> baiViets = null;
            return baiViets;
        }
        //1.2 Lấy bài viết theo ID
        [HttpGet]
        //api/BaiViet/id
        public BaiViet GetBaiVietByID(int id)
        {
            BaiViet baiViet = null;
            return baiViet;
        }
        //1.3 Lấy bài viết theo danh mục
        [HttpGet]
        //api/BaiViet/?maChuDe=value
        public List<BaiViet> GetBaiVietByChuDe(string maChuDe)
        {
            List<BaiViet> baiViets = null;
            return baiViets;
        }
        [HttpGet]
        //api/BaiViet/?ngayBD=2000-01-11 &ngayKT=2003-2-2
        public List<BaiViet> GetBaiVietByChuDe(string ngayBD, string NgayKT)
        {
            List<BaiViet> baiViets = null;
            return baiViets;
        }
        //2. thêm bài viết
        //3. Sửa bài viết
        //4. Xóa bài viết
    }
}
