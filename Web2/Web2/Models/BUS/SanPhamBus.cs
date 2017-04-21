using PhoneConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web2.Models.BUS
{
    public class SanPhamBus
    {
        public static List<SanPham> DanhSach()
        {
            var db = new PhoneConnectionDB();
            return db.Query<SanPham>("select * from SanPham").ToList<SanPham>();
        }
    }
}