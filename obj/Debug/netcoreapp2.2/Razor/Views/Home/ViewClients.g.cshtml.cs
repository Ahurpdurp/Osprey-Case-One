#pragma checksum "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76db9e9a5e7e422915e1366616c68826a2747a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewClients), @"mvc.1.0.view", @"/Views/Home/ViewClients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewClients.cshtml", typeof(AspNetCore.Views_Home_ViewClients))]
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
#line 1 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\_ViewImports.cshtml"
using Case_One;

#line default
#line hidden
#line 2 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\_ViewImports.cshtml"
using Case_One.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76db9e9a5e7e422915e1366616c68826a2747a0c", @"/Views/Home/ViewClients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee06c162770ffeda8b18edf6f394368cff92f38b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewClients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 674, true);
            WriteLiteral(@"
    <div class=""text-center"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Client ID #</th>
                    <th scope=""col"">Company Name</th>
                    <th scope=""col"">First Name</th>
                    <th scope=""col"">Last Name</th>
                    <th scope=""col"">City</th>
                    <th scope=""col"">State</th>
                    <th scope=""col"">Zip Code</th>
                    <th scope=""col"">Last Updated</th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                  
                    for (var i = 0; i < @Model.Clients.Count; i++)
                    {

#line default
#line hidden
            BeginContext(845, 90, true);
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
            EndContext();
            BeginContext(936, 25, false);
#line 27 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                               Write(Model.Clients[i].ClientId);

#line default
#line hidden
            EndContext();
            BeginContext(961, 47, true);
            WriteLiteral("</th>\r\n                                    <td>");
            EndContext();
            BeginContext(1009, 28, false);
#line 28 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1037, 48, true);
            WriteLiteral("</td> \r\n                                    <td>");
            EndContext();
            BeginContext(1086, 33, false);
#line 29 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].ContactFirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1167, 32, false);
#line 30 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].ContactLastName);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1247, 21, false);
#line 31 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].City);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1316, 22, false);
#line 32 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].State);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1386, 20, false);
#line 33 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].Zip);

#line default
#line hidden
            EndContext();
            BeginContext(1406, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1454, 28, false);
#line 34 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Model.Clients[i].LastUpdated);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1530, 160, false);
#line 35 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Html.ActionLink("Edit", "EditClient", "Home", new { id = Model.Clients[i].ClientId,
                                       @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1738, 123, false);
#line 37 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                                   Write(Html.ActionLink("Delete", "DeleteClient", "Home", new {id = Model.Clients[i].ClientId, @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\ahurpdurp\Documents\Osprey Test\ConsultingOrganization\Case One\Views\Home\ViewClients.cshtml"
                            }
                            

#line default
#line hidden
            BeginContext(1969, 60, true);
            WriteLiteral("                    </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
