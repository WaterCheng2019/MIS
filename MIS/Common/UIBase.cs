using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace MIS
{
    /// <summary>
    /// WebForm继承此类加载所需资源
    /// </summary>
    public class UIBase:System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            LoadJS();
            LoadCss();
        }

        //加载jQuery EasyUI框架
        private void LoadJS()
        {
            //jQuery1.12.4
            HtmlGenericControl jQuery1124 = new HtmlGenericControl();
            jQuery1124.TagName = "script";
            jQuery1124.Attributes.Add("type", "text/javascript");
            jQuery1124.Attributes.Add("src", "jQueryEasyUI/jquery.min.js");
            Page.Header.Controls.AddAt(1,jQuery1124);

            //jqueryEasyUI 1.7
            HtmlGenericControl easyUI17 = new HtmlGenericControl();
            easyUI17.TagName = "script";
            easyUI17.Attributes.Add("type", "text/javascript");
            easyUI17.Attributes.Add("src", "jQueryEasyUI/jquery.easyui.min.js");
            Page.Header.Controls.AddAt(2, easyUI17);

            //jquery-lang-zh_CN
            HtmlGenericControl zh_CN = new HtmlGenericControl();
            zh_CN.TagName = "script";
            zh_CN.Attributes.Add("type","text/javascript");
            zh_CN.Attributes.Add("src", "jQueryEasyUI/easyui-lang-zh_CN.js");


        }
        //加载样式文件
        private void LoadCss()
        {
            //easyui.css
            HtmlLink easyuiLink = new HtmlLink();
            easyuiLink.Href = "~/jQueryEasyUI/themes/default/easyui.css";
            easyuiLink.Attributes.Add("rel", "stylesheet");
            easyuiLink.Attributes.Add("type", "text/css");
            easyuiLink.Attributes.Add("id", "ILNetTheme");
            Page.Header.Controls.AddAt(1, easyuiLink);

            //icon.css
            HtmlLink iconLink = new HtmlLink();
            iconLink.Href = "jQueryEasyUI/themes/icon.css";
            iconLink.Attributes.Add("rel","stylesheet");
            iconLink.Attributes.Add("type", "text/css");
            Page.Header.Controls.AddAt(2,iconLink);

        }

    }


}