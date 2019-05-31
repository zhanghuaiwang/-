using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.IBLL
{
    public interface IIStudent
    {
        DataTable GetList_S(Studnet s);
    }
}
