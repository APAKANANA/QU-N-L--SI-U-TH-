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
   public class PhongbanBUL
    {
       PhongbanDAL cls = new PhongbanDAL();
       public DataTable Danhsachphongban()
       {
           return cls.Danhsachphongban();
       }
       public int Themphongban(PhongbanPublic p)
       {
           return cls.Thempb(p);
       }

       public int Suaphongban(PhongbanPublic p)
       {
           return cls.Suapb(p);
       }
    }
}
