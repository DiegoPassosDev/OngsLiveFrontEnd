#pragma checksum "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\Home\Mapa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d62c292d6cbefe1b4a993541c785cac7cc8e483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mapa), @"mvc.1.0.view", @"/Views/Home/Mapa.cshtml")]
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
#line 1 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\_ViewImports.cshtml"
using DemoPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\_ViewImports.cshtml"
using DemoPWA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d62c292d6cbefe1b4a993541c785cac7cc8e483", @"/Views/Home/Mapa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51182717c27998db487641294cde3b57c987eacd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Mapa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\Home\Mapa.cshtml"
  
    var date = DateTime.Now.ToShortDateString();
    var message = "Hello World";
    var teste = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Hoje é: ");
#nullable restore
#line 7 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\Home\Mapa.cshtml"
       Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n<h3>");
#nullable restore
#line 8 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\Home\Mapa.cshtml"
Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h1>");
#nullable restore
#line 10 "F:\gsgomes\__codigos\linguagens\csharp\2023\Github\AspNetCore-PWA\DemoPWA\Views\Home\Mapa.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<style>
    #map {
        height: 400px; /* The height is 400 pixels */
        width: 100%; /* The width is the width of the web page */
    }
</style>


 <h3>My Google Maps Demo</h3>
    <!--The div element for the map -->
    <div id=""map""></div>

<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA5caEwpXijUm3VTmIg6fRpZ0DFiXj95hw&callback=initMap""
      defer
    ></script>

    <script>
            // Initialize and add the map
            function initMap() {
              // The location of Uluru
              const uluru = { lat: -25.344, lng: 131.031 };
              // The map, centered at Uluru
              const map = new google.maps.Map(document.getElementById(""map""), {
                zoom: 4,
                center: uluru,
              });
              // The marker, positioned at Uluru
              const marker = new google.maps.Marker({
                position: uluru,
                map: map,
              });
            }

       ");
            WriteLiteral("     window.initMap = initMap;\r\n    </script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591