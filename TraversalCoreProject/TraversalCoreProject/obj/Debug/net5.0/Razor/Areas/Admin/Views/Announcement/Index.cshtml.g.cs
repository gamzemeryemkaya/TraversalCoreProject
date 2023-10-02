#pragma checksum "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0d6bf751404cd7e86d89dd0bf07c5b908c2f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Announcement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0d6bf751404cd7e86d89dd0bf07c5b908c2f06", @"/Areas/Admin/Views/Announcement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b332a3e47d20c3ac9fd0d17c58ff334be48b9260", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Announcement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Duyuru Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>İçerik</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
   Write(item.AnnouncementID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
   Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 542, "\"", 608, 2);
            WriteAttributeValue("", 549, "/Admin/Announcement/DeleteAnnouncement/", 549, 39, true);
#nullable restore
#line 26 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 588, item.AnnouncementID, 588, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 657, "\"", 723, 2);
            WriteAttributeValue("", 664, "/Admin/Announcement/UpdateAnnouncement/", 664, 39, true);
#nullable restore
#line 27 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
WriteAttributeValue("", 703, item.AnnouncementID, 703, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle</a></td>\r\n    <td><a href=\"#\" class=\"btn btn-outline-warning\">Detaylar</a></td>\r\n</tr>\r\n");
#nullable restore
#line 30 "C:\Users\gamze\source\repos\TraversalCoreProject\TraversalCoreProject\Areas\Admin\Views\Announcement\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/Announcement/AddAnnouncement/\" class=\"btn btn-outline-success\">Duyuru Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DTOLayer.DTOs.AnnouncementDTOs.AnnouncementListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591