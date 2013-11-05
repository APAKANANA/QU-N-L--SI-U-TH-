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
       NhanvienDAL cls=new NhanvienDAL();
       public DataTable Danhsachnhanvien()
       {
           return cls.Danhsachnhanvien();
       }
       public int Themnhanvien(NhanvienPublic p)
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
       
     }
}
