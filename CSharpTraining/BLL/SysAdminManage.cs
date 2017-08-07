
using DAL;
using Model;
using System.Web;

namespace BLL
{
    public class SysAdminManage
    {
        private SysAdminService objSysAdminService = new SysAdminService();
        public int CheckLogin(SysAdmin objSysAdmin)
        {
            return new SysAdminService().CheckLogin(objSysAdmin);
        }

        public SysAdmin Login(SysAdmin objSysAdmin)
        {
            objSysAdmin = objSysAdminService.Login(objSysAdmin);
            if (objSysAdmin != null)
            {
                //将登录对象保存到session
                HttpContext.Current.Session["CurrentAdmin"] = objSysAdmin;
            }
            return objSysAdmin;
        }
    }
}
