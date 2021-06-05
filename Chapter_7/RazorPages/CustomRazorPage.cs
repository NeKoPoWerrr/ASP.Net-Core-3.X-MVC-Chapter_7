using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_7.RazorPage
{
    public abstract class CustomRazorPage<dynamic> : RazorPage<dynamic>
    {
        public string AppVersion { get; } = "ASP.NET Core 3.1";
        public string GetBookName()
        {
            return "ASP.NET Core 3.1 MVC 實戰演練";
        }
    }
}
