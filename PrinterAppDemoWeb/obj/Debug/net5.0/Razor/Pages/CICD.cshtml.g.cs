#pragma checksum "C:\Users\Vlado\Desktop\PrinterApp DEMO\PrinterAppDemoWeb\Pages\CICD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa43cb84d5e119674403ba99d73c871640c1abf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PrinterAppDemoWeb.Pages.Pages_CICD), @"mvc.1.0.razor-page", @"/Pages/CICD.cshtml")]
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
#line 1 "C:\Users\Vlado\Desktop\PrinterApp DEMO\PrinterAppDemoWeb\Pages\_ViewImports.cshtml"
using PrinterAppDemoWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa43cb84d5e119674403ba99d73c871640c1abf7", @"/Pages/CICD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97356e73bb5037ae1b6cd8043a3bf9636d36e0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CICD : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<style>
    body {
        background-color: black;
    }
    .h1style {
        margin-top: 75px;
        margin-bottom: 80px;
        font-size: 45px;
        color: white;
    }

    .h2style {
        margin-top: 120px;
        margin-bottom: 100px;
        font-size: 35px;
        color: white;
    }

    .p1style {
        margin-bottom: 40px;
        text-align: left;
        color: white;
    }

    .p2style {
        
        margin-bottom: 40px;
        text-align: left;
        color: white;
    }

    .p3style {
        margin-bottom: 20px;
        text-align: left;
        color: white;
    }

    .p1style,.p2style {
        text-align: justify;
        font-size: 22px;
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
        /*background-colo");
            WriteLiteral(@"r: blue;*/
    }

</style>


<div class=""text-center"">
    <h2 class=""h2style"">Continuous integration (CI) / Continuous Deployment (CD)</h2>

    <p class=""p1style"" style=""font-weight: bold; font-size: 29px; margin-bottom: 20px;"">
        Continuous Integration (CI)
    </p>

    <p class=""p1style"">
        It is the practice of integrating changes from different developers in the team into a mainline as early as possible, in best cases several times a day. 
        This makes sure the code individual developers work on doesn’t divert too much. When you combine the process with automated testing, 
        continuous integration can enable your code to be dependable.
    </p>
    <p class=""p2style"" style=""margin-top: -23px;"">
        So whenever I push my code from my local git repository, it will trigger a few different processes.
        If all the processess passes without error, the application will be ready for deployment.
        This is an simple demo application and CI process is p");
            WriteLiteral(@"retty simple and it look like on the picture bellow.
        So as you can see, there are a few different steps, and the great thing about this is that whole process is automated.
        As soon as the build process gets done, I will get a notification on my mail and it will tell me if the process is successfull or not and where eventual errors are
        located.
    </p>

    <!-- Picture 1-->
    <div style="" width:auto; height: auto;"">
        <img src=""/css/img/CICD/img1.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black;"" alt=""image1.jpg"" />
    </div>

    <p class=""p1style"" style=""font-weight: bold; font-size: 29px; margin-bottom: 20px; margin-top: 90px"">
        Continuous Deployment (CD)
    </p>

    <p class=""p1style"">
        The final stage of a CI/CD pipeline is continuous deployment. As an extension of continuous delivery, 
        which automates the release of a production-ready build to a code repository, continuous deployment automates releasing an app to");
            WriteLiteral(@" production. 
        Because there is no manual gate at the stage of the pipeline before production, continuous deployment relies heavily on well-designed test automation.

        In practice, continuous deployment means that a developer’s change to a cloud application could go live within minutes of writing it (assuming it passes automated testing).
        This makes it much easier to continuously receive and incorporate user feedback. 
    </p>

    <p class=""p2style"" style=""margin-top: -23px;"">
        So when my ""build"" gets done and if there is no error, the continuous deployment will trigger off, and it will do the following steps as shown on the picture bellow.
        It will initialize the job, download artifacts which is that builded code, and then deploy it to the azure app service that I prepared in advance.
    </p>   

    <p class=""p2style"" style=""margin-top: -23px;"">
        This whole job is actually something that DevOps stuff would do, and even I'm a developer I think that i");
            WriteLiteral(@"t's very exciting to see the whole process of an application.
        From code to final product that's up and running.
    </p>


    <!-- Picture 2-->
    <div style="" width:auto; height: auto;"">
        <img src=""/css/img/CICD/img2.jpg"" style=""max-width: 100%; height: auto; border: solid 1px black; margin-bottom: 100px;"" alt=""image2.jpg"" />
    </div>



    <p class=""p1style"" style=""font-weight: bold; font-size: 25px; margin-bottom: 35px; margin-top: 75px"">
        Quick  CI / CD  Presentation
    </p>
    <p class=""p2style"" style=""margin-top: -23px;"">
        Pictures bellow showing a quick CI / CD presentation, lifecycle of a web application from code to production environment.
    </p>

    <div style="" width:auto; height: auto;"">
        <img name=""slide"" style=""max-width: 100%; height: auto; border: solid 1px black; margin-bottom: 100px;"" />

        <script>
            var i = 0; // start point
            var images = [];
            var time = 7000;

            // Imag");
            WriteLiteral(@"e list
            images[0] = '../css/img/CICD_SlidePresentation/1.jpg'
            images[1] = '../css/img/CICD_SlidePresentation/2.jpg'
            images[2] = '../css/img/CICD_SlidePresentation/3.jpg'
            images[3] = '../css/img/CICD_SlidePresentation/4.jpg'
            images[4] = '../css/img/CICD_SlidePresentation/5.jpg'
            images[5] = '../css/img/CICD_SlidePresentation/6.jpg'
            images[6] = '../css/img/CICD_SlidePresentation/7.jpg'
            images[7] = '../css/img/CICD_SlidePresentation/8.jpg'
            images[8] = '../css/img/CICD_SlidePresentation/9.jpg'

            // Change Image
            function changeImg() {
                document.slide.src = images[i];

                if (i < images.length - 1) {
                    i++;
                } else {
                    i = 0;
                }

                setTimeout(""changeImg()"", time);
            }

            window.onload = changeImg;

        </script>

    </div>

</di");
            WriteLiteral("v>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrinterAppDemoWeb.Pages.CICDModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrinterAppDemoWeb.Pages.CICDModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrinterAppDemoWeb.Pages.CICDModel>)PageContext?.ViewData;
        public PrinterAppDemoWeb.Pages.CICDModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
