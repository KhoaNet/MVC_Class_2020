#pragma checksum "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a8b46b038ee2f606367210ca200940410597fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\_ViewImports.cshtml"
using webClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\_ViewImports.cshtml"
using webClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8b46b038ee2f606367210ca200940410597fa7", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf6ec642b59c8756bffe3a70192696b5b0dd7f4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml"
 foreach(var emp in ViewBag.Employees){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 7 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml"
   Write(emp.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h1>");
#nullable restore
#line 8 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml"
   Write(emp.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "G:\Code\Apteach\MVC\MVC_Class_2020\28122020\webClient\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
