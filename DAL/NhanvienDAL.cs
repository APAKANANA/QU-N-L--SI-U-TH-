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
           name[0] = "@MANV";
           name[1] = "@TENNV";
           name[2] = "@GIOITINH";
           name[3] = "@CMND";
           name[4] = "@NGAYSINH";
           name[5] = "@NGAYVL";
           name[6] = "@DCHI";
           name[7] = "@DTHOAI";
           name[8] = "@MAPB";
           value[0] = p.Manv;
           value[1] = p.Tennv;
           value[2] = p.Gtinh;
           value[3] = p.Cmnd;
           value[4] = p.Ngsinh.ToString();
           value[5] = p.Ngayvl.ToString();
           value[6] = p.Dchi;
           value[7] = p.Dthoai;
           value[8] = p.Mapb;
           return cn.Update("insert into NHANVIEN values(@MANV,@TENNV,@GIOITINH,@CMND,@NGAYSINH,@NGAYVL,@DCHI,@DTHOAI,@MAPB)", name, value, Nparameter);
               
       }

       public int SuaNhanvien(NhanvienPublic p)
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
           return cn.Update("update NHANVIEN set MANV=@MANV,TENNV=@TENNV,GTINH=@GTINH,CMND=@CMND,NGSINH=@NGSINH,NGAYVL=@NGAYVL,DCHI=@DCHI,DTHOAI=@DTHOAI,MAPB=@MAPB where MANV=@MANV", name, value, Nparameter);

       }
       public int XoaNhanvien(NhanvienPublic p)
       {
           int Nparameter = 1;
           string[] name = new string[Nparameter];
           string[] value = new string[Nparameter];
           name[0] = "@MaNV";
           value[0] = p.Manv;
           return cn.Update("delete from NHANVIEN where MANV=@MANV", name, value, Nparameter);
       }
    }
}
