using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS.Ashx
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : ILHandler
    {

        public void isLogin()
        {
            string name = Request["name"];
            string pwd = Request["pwd"];

            using (MISEntities m = new MISEntities())
            {
                var p = m.People.Where(i => i.Name == name && i.Password == pwd).FirstOrDefault();

                if (p!=null)
                {
                    Response.Write("success");
                }
                else
                {
                    Response.Write("失败");
                }
            }


        }
    }
}