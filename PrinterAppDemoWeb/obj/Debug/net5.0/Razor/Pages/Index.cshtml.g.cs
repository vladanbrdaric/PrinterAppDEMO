#pragma checksum "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9f3b12b23b7478bd5f92c9faef9fc0e392c39ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PrinterAppDemoWeb.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9f3b12b23b7478bd5f92c9faef9fc0e392c39ca", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97356e73bb5037ae1b6cd8043a3bf9636d36e0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Vlado\Desktop\App DEMO from GIThub\PrinterAppDEMO\PrinterAppDemoWeb\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>

    body {
        background-color: black;
    }

    .h1style {
        margin-top: 75px;
        margin-bottom: 80px;
        font-size: 45px;
        color: white
    }

    .p1style {
        margin-bottom: 40px;
        text-align: left;
        
        
        margin-top: 100px;
        color: white

    }

    .p2style {
        
        margin-bottom: 40px;
        text-align: left;

        background-color: black;
    }

    .p1style,.p2style {
        text-align: justify;
        color: white;
        font-size: 23px;
    }

    .divStyle {
        height: 300px;
        width: 700px;
        background-color: red;
    }

    .imgStyle {
/*       width: 400px;
        height: 200px;*/
        height: 450px;
        width: 1000px;
        margin-top: 5px;
        /*background-color: blue;*/
    }
</style>


<div class=""text-center"">
");
            WriteLiteral(@"    <h1 class=""h1style"" style=""font-size: 55px; margin-top: 120px;"">PRINTER APPLICATION DEMO</h1>

    <p class=""p1style"">
        This application allows the user to retrieve a lot of different values from the objects, in my case printers are maintained by the SNMP agent. 
        Pictures below represent a ""step by step"" overview of how this application works. There is also a 'CI/CD' menu choice where you can see how I automated this
        whole process from the development (when I write code in Visual Studio) to deployment (when the application is in real prodution environment and it's accessable to anybody in the world).
        Check the 'CI/CD' page for more information.
    </p>

    <p class=""p2style"">
        First picture is showing a few different components that this application has. 
        As you can see, main components of this application is an API which is playing a key role in this whole project.
        There is also an 'SQLite' database, 'Data Access' and 'Business Logic' la");
            WriteLiteral(@"yers which has all the necessary methods and queries that this application uses. 
        User interface is actually what the user sees and interact with. 
        UI has no direct access to the database, and everything goes through the API, 
        which means that I can easily change ASP.NET Razor pages against desktop application or maybe 'React.js'/'Angular' application.
    </p>

    <p class=""p2style"" style=""margin-top: -20px;"">
        Printer agent should be installed on the printer server and it should have access to all printers locally. 
        In real life it should communicate with the API through websockets and it will represent a client while API represent a server.
    </p>

    <!-- Picture 1-->
    <div style="" width:auto; height: auto;"">
        <img src=""/css/img/image1.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image1.jpg"" />
    </div>

    <p class=""p2style"" style=""margin-top: 80px;"">
        When the user starts the application for the ");
            WriteLiteral(@"first time, he/she should add a new printer. 
        So when ""Add New"" button has been pressed it'll redirect the user to a new page where the user has to provide 
        a printer local ""IP address"", a ""Location"" (e.g. 'IT department') and a short ""Description"" (e.g. 'Laser printer') about the printer. 
        Each time when user add a new printer and press the ""Save"" button it will be redirected to a new page where he/she can choose between three alternatives, 
        to keep adding printers, return to a home page or see the status of all available printers. 
        The thing that the user can't see is when 'Save' button has been pressed it will send that printer object in form of text to ""Azure Queue Service Bus"".
        And then ""Add Printer Service Bus"" will get that printer object and store it in the database.
        This means that application will not crash even if some other parts of applicationen are offline.
    </p>

    <!--Picture 2-->
    <div style="" width:auto; height: auto;");
            WriteLiteral(@""">
        <img src=""/css/img/image2.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image2.jpg"" />
    </div>

    <p class=""p2style"" style=""margin-top: 80px;"">
        When you finally press ""Check Status"" it triggers a HttpGet request and inside API it???ll run a method 
        that will find and get all IP addresses that are stored in the database. 
        Once the API has that/those IP address it will send it to the 'Agent' which will run all predefined methods against the provided ip addresses (printers) 
        Methods inside the agent contains all kind of different SNMP Get requests and those will be run one by one asynchronously and the 'Agent' will wait until all the methods complete their tasks.
    </p>



    <!--Picture 3-->
    <div style="" width:auto; height: auto;"">
        <img src=""/css/img/image3.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image3.jpg"" />
    </div>


    <p class=""p2style"" style=""margin-top: 80px;""");
            WriteLiteral(@">
        Once all tasks have been completed all the retrieved information will be sent back to the API, 
        which will forward those (with help of business logic and data access methods) right into the database.
    </p>
    <!--Picture 4-->
    <div style="" width:auto; height: auto;"">
        <img src=""/css/img/image4.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image4.jpg"" />
    </div>

    <p class=""p2style"" style=""margin-top: 80px;"">
        The last step is to get all information from the database and present them to the user. 
        Pictures are unfortunately too small for all data to be shown and that's why you should click on the ""To the top of the page"" link that will take you to the
        top of the page. Press ""Check Status"" button on the menu line and see the final result of this application. 
        In this demo application you don't have to add any printer in the beginning because I already added some example printers. 
        But I recomme");
            WriteLiteral(@"nd you to go to that page and try it out, because when you press the 'save' button you will reach one page that is not accessable in some other way.
        Depending on the level of toners and trays the 'State' column will change between 'Running', 'Warning' and 'Down', and column 'Device Status' between 'OK' and 'ERROR'
        if the printer is unreachable.
    </p>
    <!--Picture 5-->
    <div style="" width:auto; height: auto; margin-bottom: 80px;"">
        <img src=""/css/img/image5.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image5.jpg"" />
    </div>

    <a href=""/Index""><p style=""width: auto; color: white; text-align: center; height: auto; margin-bottom: 80px; font-weight: bold; font-size: 25px;""> >>> To the top of the page <<< </p></a>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
