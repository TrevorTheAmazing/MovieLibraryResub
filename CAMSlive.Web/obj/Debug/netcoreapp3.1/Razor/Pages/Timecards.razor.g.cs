#pragma checksum "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca06a6bcadaaa615b2e444f606013e449b36ee77"
// <auto-generated/>
#pragma warning disable 1591
namespace CAMSlive.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using CAMSlive.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\_Imports.razor"
using CAMSlive.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/timecards")]
    public partial class Timecards : TimecardsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    body {\n        background-color: #d8e7ef;\n    }\n</style>\n\n");
            __builder.AddMarkupContent(1, "<h1 style=\"color: #15416e; \">Timecards Dashboard</h1>\n<hr>\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "timecards");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\n\n\n");
#nullable restore
#line 16 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
     if (TimecardCharts == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<CAMSlive.Web.Shared.Loader>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 19 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "cards");
            __builder.AddMarkupContent(12, "\n\n");
#nullable restore
#line 24 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
             foreach (var chart in TimecardCharts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenComponent<CAMSlive.Web.Shared.Chart>(14);
            __builder.AddAttribute(15, "ChartId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
                                 chart.ChartId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChartOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
                                                               chart.ChartOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 27 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 29 "C:\Users\Trevor\Desktop\fresh\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive\CAMSlive.Web\Pages\Timecards.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n");
            __builder.OpenComponent<CAMSlive.Web.Shared.ScrollToTop>(21);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
