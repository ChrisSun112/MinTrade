using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WechatMPCloud.Controllers
{
    /// <summary>
    /// 微信公众号菜单页模板
    /// </summary>
    public class TemplateController : Controller
    {
       
        /// <summary>
        /// 活动优惠
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

    }
}
