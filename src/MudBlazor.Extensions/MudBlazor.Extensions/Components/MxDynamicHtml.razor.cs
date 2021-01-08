using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MudBlazor.Extensions
{
    public partial class MxDynamicHtml : MudComponentBase
    {

        [Parameter] public string Html { get; set; }
        
        RenderFragment DynamicRenderFragment()
        {
            return new RenderFragment(builder =>
            {
                builder.AddMarkupContent(0, Html);
            });
        }
        
    }
}
