﻿using System.Web;
using System.Web.Mvc;

namespace AspNetMVCApi.PL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
