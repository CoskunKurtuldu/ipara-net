﻿using System.Web;
using System.Web.Mvc;

namespace IPara.DeveloperPortal.WebSamples
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
