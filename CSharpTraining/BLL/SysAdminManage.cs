
using DAL;
using Model;

namespace BLL
{
    public class SysAdminManage
    {
        public int CheckLogin(SysAdmin objSysAdmin)
        {
            return new SysAdminService().CheckLogin(objSysAdmin);
        }

        public SysAdmin Login(SysAdmin objSysAdmin)
        {
            return new SysAdminService().Login(objSysAdmin);
        }
    }
}
