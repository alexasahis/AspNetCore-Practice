﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerBaseHelpDemo.Controllers
{
    [Route("Redirect/[action]")]
    [ApiController]
    public class RedirectController : ControllerBase
    {
        /// <summary>
        /// Return HTTP 302 and Redirect URL
        /// 回傳 HTTP 302 和重導向 URL
        /// </summary>
        /// <returns>RedirectResult</returns>
        public IActionResult DemoRedirect1()
        {
            return Redirect("http://skilltree.my");
        }

        /// <summary>
        /// Return HTTP 301 and Redirect URL
        /// 回傳 HTTP 301 和重導向 URL
        /// </summary>
        /// <returns>RedirectResult</returns>
        public IActionResult DemoRedirect2()
        {
            return RedirectPermanent("http://skilltree.my");
        }

        /// <summary>
        /// Return HTTP 307 and Redirect URL
        /// 回傳 HTTP 307 和重導向 URL
        /// </summary>
        /// <returns>RedirectResult</returns>
        public IActionResult DemoRedirect3()
        {
            return RedirectPreserveMethod("http://skilltree.my");
        }

        /// <summary>
        /// Return HTTP 308 and Redirect URL
        /// 回傳 HTTP 308 和重導向 URL
        /// </summary>
        /// <returns>RedirectResult</returns>
        public IActionResult DemoRedirect4()
        {
            return RedirectPermanentPreserveMethod("http://skilltree.my");
        }


        // ========== preventing-open-redirects ==========
        // Ref: https://docs.microsoft.com/zh-tw/aspnet/core/security/preventing-open-redirects

        /// <summary>
        /// Return HTTP 302 and Redirect URL, Non-Local Url will throw exception.
        /// 回傳 HTTP 302 和重導向 URL，非本機 URL 會擲回例外狀況。
        /// </summary>
        /// <returns>LocalRedirectResult</returns>
        public IActionResult DemoRedirect5()
        {
            return LocalRedirect("http://skilltree.my");
        }

        /// <summary>
        /// Return HTTP 302 and Redirect URL.
        /// 回傳 HTTP 302 和重導向 URL。
        /// </summary>
        /// <returns>LocalRedirectResult</returns>
        public IActionResult DemoRedirect6()
        {
            return LocalRedirect("~/Content/DemoUnicode");
        }

        /// <summary>
        /// Return HTTP 301 and Redirect URL.
        /// 回傳 HTTP 301 和重導向 URL。
        /// </summary>
        /// <returns>LocalRedirectResult</returns>
        public IActionResult DemoRedirect7()
        {
            return LocalRedirectPermanent("~/Content/DemoUnicode");
        }

        /// <summary>
        /// Return HTTP 307 and Redirect URL.
        /// 回傳 HTTP 307 和重導向 URL。
        /// </summary>
        /// <returns>LocalRedirectResult</returns>
        public IActionResult DemoRedirect8()
        {
            return LocalRedirectPreserveMethod("~/Content/DemoUnicode");
        }

        /// <summary>
        /// Return HTTP 308 and Redirect URL.
        /// 回傳 HTTP 308 和重導向 URL。
        /// </summary>
        /// <returns>LocalRedirectResult</returns>
        public IActionResult DemoRedirect9()
        {
            return LocalRedirectPermanentPreserveMethod("~/Content/DemoUnicode");
        }

        // ToDo: MVC?
        //RedirectToAction()
        //RedirectToAction(string actionName)
        //RedirectToAction(string actionName, object routeValues)
        //RedirectToAction(string actionName, string controllerName)

        // ToDo: MVC?
        //RedirectToActionPermanent(string actionName)
        //RedirectToActionPermanent(string actionName, object routeValues)
        //RedirectToActionPermanent(string actionName, string controllerName)
        //RedirectToActionPermanent(string actionName, string controllerName, string fragment)
        //RedirectToActionPermanent(string actionName, string controllerName, object routeValues)
        //RedirectToActionPermanent(string actionName, string controllerName, object routeValues, string fragment)

        // ToDo: MVC?
        //RedirectToRoute(string routeName)
        //RedirectToRoute(object routeValues)
        //RedirectToRoute(string routeName, object routeValues)
        //RedirectToRoute(string routeName, string fragment)


        // ToDo: MVC?
        //RedirectToRoutePermanent(string routeName)
        //RedirectToRoutePermanent(object routeValues)
        //RedirectToRoutePermanent(string routeName, object routeValues)
        //RedirectToRoutePermanent(string routeName, string fragment)

        // ToDo: MVC?
        //RedirectToPage(string pageName)
        //RedirectToPage(string pageName, object routeValues)
        //RedirectToPage(string pageName, string pageHandler)
        //RedirectToPage(string pageName, string pageHandler, object routeValues)
        //RedirectToPage(string pageName, string pageHandler, string fragment)
        //RedirectToPage(string pageName, string pageHandler, object routeValues, string fragment)

        // ToDo: MVC?
        //RedirectToPagePermanent(string pageName)
        //RedirectToPagePermanent(string pageName, object routeValues)
        //RedirectToPagePermanent(string pageName, string pageHandler)
        //RedirectToPagePermanent(string pageName, string pageHandler, string fragment)
    }
}