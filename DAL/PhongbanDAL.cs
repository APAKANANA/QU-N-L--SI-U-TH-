using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public;
using System.Data;

namespace DAL
{
   public class PhongbanDAL
    {
       clsKetnoi cn = new clsKetnoi();
       public DataTable Danhsachphongban()
       {
           return cn.LoadData("select * from PHONGBAN");
       }

       public int Thempb(PhongbanPublic p)
       {
           int Nparameter = 4;
           string[] name = new string[Nparameter];
           string[] value = new string[Nparameter];
           name[0] = "@MAPB";
           name[1] = "@TENPB";
           name[2] = "@TENNDN";
           name[3] = "@PASS";
           value[0] = p.Mapb;
           value[1] = p.Tenpb;
           value[2] = p.Tenndn;
           value[3] = p.Pass;
           return cn.Update("insert into PHONGBAN values(@MAPB,@TENPB,@TENNDN,@PASS)", name, value, Nparameter);
       }
    }
}
