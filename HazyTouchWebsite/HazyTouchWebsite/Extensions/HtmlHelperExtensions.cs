using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HazyTouchWebsite.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Copyright(this HtmlHelper helper)
        {
            return helper.Raw($"&copy; H + Sport {DateTime.Now.Year}");
        }
    }
}