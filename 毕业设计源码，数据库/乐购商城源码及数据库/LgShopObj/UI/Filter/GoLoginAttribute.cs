﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filter
{
    public class GoLoginAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 阻止浏览器直接跳转到用户界面
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["user"] == null) {
                filterContext.Result = new RedirectResult("/Home/Index");
            }
        }
    }
}