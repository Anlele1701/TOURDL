//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

#line 2 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
using PagedList.Mvc;

#line default
#line hidden

public class _Page_AppData_Local_Temp_E3807FC56473B6003AD625B957B4845E0AE0_2_TOURDL_TOURDL_Views_TOURs_DanhMucTour_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_AppData_Local_Temp_E3807FC56473B6003AD625B957B4845E0AE0_2_TOURDL_TOURDL_Views_TOURs_DanhMucTour_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
__o = model;


#line default
#line hidden

#line 3 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
  
    ViewBag.Title = "DanhMucTour";
    Layout = "~/Views/Shared/CusLayout.cshtml";


#line default
#line hidden

#line 4 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
        foreach (var item in Model)    
        {
            

#line default
#line hidden

#line 5 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
                                                       __o = item.HinhAnh;


#line default
#line hidden

#line 6 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
                                          __o = Html.DisplayFor(modelItem => item.TenSPTour);


#line default
#line hidden

#line 7 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
                                        __o = Html.DisplayFor(modelItem => item.GiaNguoiLon);


#line default
#line hidden

#line 8 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
                            __o = Url.Action("ChiTietTour", "ChiTietTour", new { id = item.ID_SPTour });


#line default
#line hidden

#line 9 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
                  
        }

#line default
#line hidden

#line 10 "C:\Users\Admin\AppData\Local\Temp\E3807FC56473B6003AD625B957B4845E0AE0\2\TOURDL\TOURDL\Views\TOURs\DanhMucTour.cshtml"
__o = Html.PagedListPager(Model, page => Url.Action("DanhMucTour", new { page, name = Request.QueryString["name"], from = Request.QueryString["from"], to = Request.QueryString["to"] }));


#line default
#line hidden
}
}
}
