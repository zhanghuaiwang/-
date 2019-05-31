using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Helper;
using WindowsFormsApp3.IBLL;

namespace WindowsFormsApp3.BLL
{
    public class StudentBll: IIStudent
    {
        public DataTable GetList_S(Studnet s)
        {
            DB.IDB dd = new DB.DBByHandClose(AppSetting.con);
            return dd.ExecuteToTable($"select * from Student ");
        }
    }
}
