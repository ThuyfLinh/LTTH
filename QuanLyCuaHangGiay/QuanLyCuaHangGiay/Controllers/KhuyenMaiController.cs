using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TTN.DAO;

namespace QuanLyCuaHangGiay.Controllers
{
    public class KhuyenMaiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetKhuyenMai(string query)
        {
            DataTable tb = new DataTable();
            //DataProvider sql = new DataProvider.ExecuteQuery("select * from KhuyenMai");
            return Request.CreateResponse(HttpStatusCode.OK, tb);
            //return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, error);
        }

    }
}
