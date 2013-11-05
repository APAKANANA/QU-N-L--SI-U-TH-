using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Public;
using System.Data;

namespace DAL
{
   public class NhanvienDAL
    {
       clsKetnoi cn = new clsKetnoi();
       public DataTable Danhsachnhanvien()
       {
           return cn.LoadData("select * from NHANVIEN");
       }
       public int ThemNhanvien(NhanvienPublic p)
       {
           int Nparameter = 9;
           string[] name = new string[Nparameter];
           string[] value = new string[Nparameter];
           name[0] = "@MaNV";
           name[1] = "@TenNV";
           name[2] = "@Gtinh";
           name[3] = "@Cmnd";
           name[4] = "@Ngsinh";
           name[5] = "@Ngayvl";
           name[6] = "@Dchi";
           name[7] = "@Dthoai";
           name[8] = "@MaPB";
           value[0] = p.Manv;
           value[1] = p.Tennv;
           value[2] = p.Gtinh;
           value[3] = p.Cmnd;
           value[4] = p.Ngsinh.ToString();
           value[5] = p.Ngayvl.ToString();
           value[6] = p.Dchi;
           value[7] = p.Dthoai;
           value[8] = p.Mapb;
           return cn.Update("insert into NHANVIEN values(@MaNV,@TenNV,@Gtinh,@Cmnd,@Ngsinh,@Ngayvl,@Dchi,@Dthoai,@MaPB)", name, value, Nparameter);
               
       }
    }
}
