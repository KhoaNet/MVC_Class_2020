#MVC_Class_2020


Nuget MVC core  - migrations

 //[ADD][Package Migration]
 Install-Package Microsoft.EntityFrameworkCore
 Install-Package Microsoft.EntityFrameworkCore.Tools
 Install-Package Microsoft.EntityFrameworkCore.SqlServer 
 Install-Package Microsoft.Extensions.Configuration 
 Install-Package Microsoft.Extensions.Configuration.Json 
 Install-Package Microsoft.EntityFrameworkCore.Design
 //[END]


 //[ADD][Change HTMl load page]
  Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation  

 var mvcBuilder = services.AddControllersWithViews();
  mvcBuilder.AddRazorRuntimeCompilation();
  //[END]



































