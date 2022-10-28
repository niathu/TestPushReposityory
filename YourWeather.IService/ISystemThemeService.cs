﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourWeather.Model.Enum;

namespace YourWeather.IService
{
    public interface ISystemThemeService
    {
        public bool IsDark(ThemeState themeState);
        event Action Onchange;
        public void AddSystemThemeHandler();
        public void ClearSystemThemeHandler();
    }
}
