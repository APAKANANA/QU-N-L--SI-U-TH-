using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Public;

namespace DAL
{
   public class NhaccDAL
    {
       clsKetnoi cn = new clsKetnoi();
       public DataTable Danhsachnhacungcap()
       {
           return cn.LoadData("select * from NHACUNGCAP");
       }
       public int Themnhacc(NhaccPublic p)
       {
           int Nparameter = 4;
           string[] name = new string[Nparameter];
           object[] value = new object[Nparameter];
           name[0] = "@MaNCC";
           name[1] = "@TenNCC";
           name[2] = "@Dchi";
           name[3] = "@Dthoai";
           value[0] = p.Mancc;
           value[1] = p.Tenncc;
           value[2] = p.Dchi;
           value[3] = p.Dthoai;
           return cn.Update("insert into NHACUNGCAP values(@MaNCC,@TenNCC,@Dchi,@Dthoai)", name, value, Nparameter);
       }
    }
}
