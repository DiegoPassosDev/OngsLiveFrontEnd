#pragma checksum "C:\Users\monte\OneDrive\Documents\GitHub\OngsLiveFrontEnd\OngLivesPWA\Views\Home\Mapa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3633732896deaac44d24f2175236cd0ae1e0d462"
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
#line 1 "C:\Users\monte\OneDrive\Documents\GitHub\OngsLiveFrontEnd\OngLivesPWA\Views\_ViewImports.cshtml"
using OngLivesPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\monte\OneDrive\Documents\GitHub\OngsLiveFrontEnd\OngLivesPWA\Views\_ViewImports.cshtml"
using OngLivesPWA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3633732896deaac44d24f2175236cd0ae1e0d462", @"/Views/Home/Mapa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84a91e9dd66ac924f48dcaf9859e3ff68a221ce2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Mapa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\monte\OneDrive\Documents\GitHub\OngsLiveFrontEnd\OngLivesPWA\Views\Home\Mapa.cshtml"
  
    ViewData["Title"] = "Mapa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #map {
        height: 400px; /* The height is 400 pixels */
        width: 100%; /* The width is the width of the web page */
    }
</style>


 <h3>Google Maps</h3>
    <!--The div element for the map -->
    <div id=""map""></div>

<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA5caEwpXijUm3VTmIg6fRpZ0DFiXj95hw&callback=initMap""
      defer
    ></script>

    <script>
            // Initialize and add the map
            function initMap() {
              // The location of Uluru
              const uluru = { lat: -10.9095, lng: -37.0748 };
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

            window.i");
            WriteLiteral("nitMap = initMap;\r\n    </script>\r\n");
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
