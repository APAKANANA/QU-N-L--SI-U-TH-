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

       int Nparameter = 9;
       string[] name = new string[9];
       string[] value = new string[9];

       public DataTable DanhsachNhanvien()
       {
           return cn.LoadData("select *from NHANVIEN");
       }

       public int ThemNhanvien(NhanvienPublic p)
       {
           parameter(p);
           return cn.Update("insert into NHANVIEN values(@MaNV,@TenNV,@GioiTinh,@Cmnd,@NgaySinh,@Ngayvl,@DChi,@DThoai,@MaPB)", name, value, Nparameter);
       }

       public int SuaNhanvien(NhanvienPublic p)
       {
           parameter(p);
           return cn.Update("update NHANVIEN set TenNV=@TenNV,GioiTinh=@GioiTinh,Cmnd=@Cmnd,NgaySinh=@NgaySinh,Ngayvl=@Ngayvl,DChi=@DChi,DThoai=@DThoai,MaPB=@MaPB where MaNV=@MaNV", name, value, Nparameter);
       }

       public int XoaNhanvien(NhanvienPublic p)
       {
           parameter(p);
           return cn.Update("delete from NHANVIEN where MaNV=@MaNV", name, value, 1);
       }

       public DataTable TimNhanvien(string strSearch, string Search)
       {

           return cn.LoadData("select * from NHANVIEN where " + strSearch + " like '%" + Search + "%'");
       }

       public int SuaMaNVthanhnull(HoadonPublic q)
       {
           name[0]="@MANV";
           value[0] = q.Manv;
           return cn.Update("update HOADON set MANV = null where MANV=@MANV",name, value, 1);
       }

       public void parameter(NhanvienPublic p)
       {
           
           name[0] = "@MaNV";
           name[1] = "@TenNV";
           name[2] = "@GioiTinh";
           name[3] = "@Cmnd";
           name[4] = "@NgaySinh";
           name[5] = "@Ngayvl";
           name[6] = "@DChi";
           name[7] = "@DThoai";
           name[8] = "@MaPB";
           value[0] = p.Manv;
           value[1] = p.Tennv;
           value[2] = p.Gioitinh;
           value[3] = p.Cmnd;
           value[4] = p.Ngaysinh;
           value[5] = p.Ngayvl;
           value[6] = p.Dchi;
           value[7] = p.Dthoai;
           value[8] = p.Mapb;
       }
    }
}
