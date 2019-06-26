using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.SessionState;

namespace MIS
{
    public class ILHandler : IHttpHandler, IRequiresSessionState
    {
        public HttpRequest Request { get; private set; }
        public HttpResponse Response { get; private set; }
        public HttpSessionState Session { get; private set; }
        public HttpContext Context { get; private set; }
        public HttpServerUtility Server { get; private set; }

        public ILHandler() { }
        public ILHandler(HttpContext context)
        {
            this.Request = context.Request;
            this.Response = context.Response;
            this.Session = context.Session;
            this.Server = context.Server;
            this.Context = context;
        }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                context.Response.Buffer = true;
                context.Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
                context.Response.AddHeader("pragma","no-cache");
                context.Response.AddHeader("cache-control", "");
                context.Response.CacheControl = "no-cache";
                this.Request = context.Request;
                this.Response = context.Response;
                this.Context = context;
                this.Server = context.Server;
                this.Session = context.Session;

                String method = Request["Method"].ToString();
                MethodInfo methodInfo = this.GetType().GetMethod(method);
                methodInfo.Invoke(this,null); 


            }
            catch (Exception ex)
            {
                
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

      
    }
}