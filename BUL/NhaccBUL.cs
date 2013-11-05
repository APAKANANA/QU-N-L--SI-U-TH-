using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using Public;
using System.Data;

namespace BUL
{
    public class NhaccBUL
    {
        NhaccDAL cls = new NhaccDAL();
        public DataTable Danhsachnhacungcap()
        {
            return cls.Danhsachnhacungcap();
        }
        public int Themnhacc(NhaccPublic p)
        {
            return cls.Themnhacc(p);
        }
    }
}
