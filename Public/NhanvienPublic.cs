using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
   public class NhanvienPublic:PhongbanPublic
    {
        string manv;
        string tennv;
        string gioitinh;
        string cmnd;
        string ngaysinh;
        string ngayvl;
        string dchi;
        string dthoai;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        

        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        

        public string Ngayvl
        {
            get { return ngayvl; }
            set { ngayvl = value; }
        }
        

        public string Dchi
        {
            get { return dchi; }
            set { dchi = value; }
        }
        

        public string Dthoai
        {
            get { return dthoai; }
            set { dthoai = value; }
        }
    }
}
