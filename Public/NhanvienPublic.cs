using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
   public class NhanvienPublic:PhongbanPublic
    {
        string _Manv;
        string _Tennv;
        string _Gtinh;
        string _Cmnd;
        DateTime _Ngsinh;
        DateTime _Ngayvl;
        string _Dchi;
        string _Dthoai;

        public string Manv
        {
            get { return _Manv; }
            set { _Manv = value; }
        }
        

        public string Tennv
        {
            get { return _Tennv; }
            set { _Tennv = value; }
        }
        

        public string Gtinh
        {
            get { return _Gtinh; }
            set { _Gtinh = value; }
        }
        

        public string Cmnd
        {
            get { return _Cmnd; }
            set { _Cmnd = value; }
        }
        

        public DateTime Ngsinh
        {
            get { return _Ngsinh; }
            set { _Ngsinh = value; }
        }
        

        public DateTime Ngayvl
        {
            get { return _Ngayvl; }
            set { _Ngayvl = value; }
        }
        

        public string Dchi
        {
            get { return _Dchi; }
            set { _Dchi = value; }
        }
        

        public string Dthoai
        {
            get { return _Dthoai; }
            set { _Dthoai = value; }
        }
    }
}
