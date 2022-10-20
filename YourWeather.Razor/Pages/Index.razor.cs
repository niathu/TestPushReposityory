﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourWeather.Razor.Pages
{
    public partial class Index
    {
        [Inject]
        IJSRuntime JS { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await JS.InvokeVoidAsync("disableBack");
        }
    }
}
