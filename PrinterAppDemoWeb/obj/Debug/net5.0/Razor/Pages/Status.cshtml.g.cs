#pragma checksum "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f0af5f7ce677fbcfe43884edfc9d27319707a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PrinterAppDemoWeb.Pages.Pages_Status), @"mvc.1.0.razor-page", @"/Pages/Status.cshtml")]
namespace PrinterAppDemoWeb.Pages
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
#line 1 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\_ViewImports.cshtml"
using PrinterAppDemoWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f0af5f7ce677fbcfe43884edfc9d27319707a4", @"/Pages/Status.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97356e73bb5037ae1b6cd8043a3bf9636d36e0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Status : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>

    .content-table {
        background-color: #F8F8F8;
        font-weight: bold;
        width: 1600px;
        border-collapse: collapse;
        margin: 100px 0;
        margin-left: -280px;
        font-size: 0.7em;
        min-width: 800px;
        border-radius: 5px 5px 0 0;
        overflow: hidden;
        box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
    }

    .content-table thead tr {
        /*background-color: #009879;*/
        background-color: black;
        color: #ffffff;
        text-align: left;
        font-weight: bold;
    }

    .content-table thead th:first-child {
        padding-left: 20px;
    }

    .content-table tbody td:first-child {
        padding-left: 20px;
    }

    .content-table th,
    .content-table td{
        padding: 6px 3px;
        text-align: center;
    }

    .content-table th {
        width: 180px;
    }

/*    .content-table tbody tr {
        border-bottom: 1px solid #dddddd;
    }*/

/*    .content-tab");
            WriteLiteral(@"le tbody tr:nth-of-type(even) {
        background-color: #f3f3f3;
    }*/

    /*.content-table tbody tr:last-of-type{*/
        /*border-bottom: 2px solid #009879;*/
        /*border-bottom: 2px solid black;
    }*/

    .content-table tbody tr.active-row {
        font-weight: bold;
        /*color: #009879;*/
        color: black;
    }

    .h2style{
        margin-top: 90px;
        margin-bottom: 30px;
    }

    #blinkId {
        font-size: 20px;
        font-weight: bold;
        color: red;
        transition: 0.5s;
    }

    .blink {
        /*color: red;*/
        font-weight: 500;
        font-weight: 900;
    }

    .border_down {
        border-bottom: 0.5px solid black;
    }

</style>


");
#nullable restore
#line 98 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
 if (Model.Printers.Count > 0)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""content-table"" style=""border-bottom: solid 2px black;"">
        <thead>
            <tr>
                <th class=""align_left"">IP Address</th>
                <th class=""align_left"">Description</th>
                <th class=""align_left"">Location</th>
                <th class=""align_left"">Manufacturer</th>
                <th class=""align_left"">Model</th>
                <th>Up Time</th>
                <th>Life Count</th>
                <th>Device Status</th>
                <th>State</th>
                <th>Black</th>
                <th>Cyan</th>
                <th>Magenta</th>
                <th>Yellow</th>
                <th>Tray 1</th>
                <th>Tray 2</th>
                <th>Tray 3</th>
                <th>Tray 4</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 126 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
        foreach (var printer in Model.Printers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size: 13px\">\r\n");
#nullable restore
#line 129 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "down")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: #C8C8C8\">");
#nullable restore
#line 131 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                                          Write(printer.IpAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 132 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 135 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.IpAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 136 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 138 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "down")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: #C8C8C8\">");
#nullable restore
#line 140 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                                          Write(printer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 141 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 144 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 145 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 147 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "down")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: #C8C8C8\">");
#nullable restore
#line 149 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                                          Write(printer.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 150 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 153 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 154 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 156 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "down")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: #C8C8C8\">");
#nullable restore
#line 158 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                                          Write(printer.Manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 159 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 162 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 163 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 165 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "down")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: #C8C8C8\">");
#nullable restore
#line 167 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                                          Write(printer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 168 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 171 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 172 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <td>");
#nullable restore
#line 174 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
               Write(printer.UpTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 175 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
               Write(printer.LifeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 176 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "running")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>OK</td>\r\n");
#nullable restore
#line 179 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }
                else if(printer.Status.ToLower() == "warning")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>OK</td>\r\n");
#nullable restore
#line 183 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>ERROR</td>\r\n");
#nullable restore
#line 187 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if(printer.Status.ToLower() == "running")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: green\">RUNNING</td>\r\n");
#nullable restore
#line 191 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                else if (printer.Status.ToLower() == "warning")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: orange\">WARNING</td>\r\n");
#nullable restore
#line 195 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"blink\" style=\"color: red\">DOWN</td>\r\n");
#nullable restore
#line 199 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if (printer.Black > 0)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 202 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Black);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 203 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                 else
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 207 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 if (printer.Cyan > 0)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 210 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Cyan);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 211 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }
                 else
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 215 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 216 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Magenta > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 218 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Magenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 219 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 223 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 224 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Yellow > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 226 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Yellow);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 227 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 231 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 232 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Tray1 > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 234 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Tray1);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 235 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 239 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 240 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Tray2 > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 242 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Tray2);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 243 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 247 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 248 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Tray3 > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 250 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Tray3);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 251 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 255 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 256 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  if (printer.Tray4 > 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 258 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                   Write(printer.Tray4);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 259 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td></td>\r\n");
#nullable restore
#line 263 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 265 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 268 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"font-size: 50px; text-align: center; margin-top: 200px\">You have not added any printer yet.</h2>\r\n");
#nullable restore
#line 272 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Status.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script type=""text/javascript"">
    var blinkId = document.getElementById('blinkId');
    setInterval(function() {
        blinkId.style.opacity = (blinkId.style.opacity == 0 ? 1 : 0);
    }, 500);


    function blinkIt() {
        var blinks = document.getElementsByClassName(""blink"");
        for(var i = 0, l = blinks.length; i < l; i++){
            var blink = blinks[i];
            var visiblity = blink.style.visibility;
            blink.style.visibility = visiblity == 'visible' ? 'hidden' : 'visible';
        }
    }

    setInterval(blinkIt, 1300 /* blinking interval in ms */);
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrinterApplicationWebUI.Pages.StatusModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrinterApplicationWebUI.Pages.StatusModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrinterApplicationWebUI.Pages.StatusModel>)PageContext?.ViewData;
        public PrinterApplicationWebUI.Pages.StatusModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
