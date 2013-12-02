using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public;
using DAL;
using System.Data;

namespace BUL
{
   public class NhanvienBUL
    {
       NhanvienDAL cls = new NhanvienDAL();

       public DataTable DanhsachNhanvien()
       {
           return cls.DanhsachNhanvien();
       }

       public int ThemNhanvien(NhanvienPublic p)
       {
           return cls.ThemNhanvien(p);
       }

       public int SuaNhanvien(NhanvienPublic p)
       {
           return cls.SuaNhanvien(p);
       }

       public int XoaNhanvien(NhanvienPublic p)
       {
           return cls.XoaNhanvien(p);
       }

       public DataTable TimNhanvien(string strSearch, string Search)
       {
           return cls.TimNhanvien(strSearch, Search);
       }

       public int SuaManvtrongHD(HoadonPublic q)
       {
           return cls.SuaMaNVthanhnull(q);
       }
    }
}
