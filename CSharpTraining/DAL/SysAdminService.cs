
using DAL.Helper;
using Model;
using System;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class SysAdminService
    {
        public int CheckLogin(SysAdmin objSysAdmin)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from [dbo].[Admins] where LoginId={0} and LoginPwd={1}");
            string sql = string.Format(sqlBuilder.ToString(), objSysAdmin.LoginId, objSysAdmin.LoginPwd);

            try
            {
                return SQLHelper.Update(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public SysAdmin Login(SysAdmin objSysAdmin)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("select * from [dbo].[Admins] where LoginId={0} and LoginPwd={1}");
            string sql = string.Format(sqlBuilder.ToString(), objSysAdmin.LoginId, objSysAdmin.LoginPwd);

            try
            {
                SqlDataReader objReaders = SQLHelper.GetDataReader(sql);
                if (objReaders.Read())
                {
                    objSysAdmin.AdminName = objReaders["AdminName"].ToString();
                    objReaders.Close();    
                }
                
                return objSysAdmin;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
