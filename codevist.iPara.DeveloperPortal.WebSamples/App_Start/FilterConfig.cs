﻿using System.Web;
using System.Web.Mvc;

namespace codevist.iPara.DeveloperPortal.WebSamples
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}