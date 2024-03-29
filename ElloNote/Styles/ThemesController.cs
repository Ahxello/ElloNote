﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ElloNote.Styles
{
        public static class ThemesController
        {
            public enum ThemeTypes
            {
                Light, ColourfulLight,
                Dark, ColourfulDark
            }

            public static ThemeTypes CurrentTheme { get; set; }

            private static ResourceDictionary ThemeDictionary
            {
                get { return Application.Current.Resources.MergedDictionaries[0]; }
                set { Application.Current.Resources.MergedDictionaries[0] = value; }
            }

            public static SolidColorBrush GetSolidBrush(string name)
            {
                object brush = ThemeDictionary[name];
                return brush is SolidColorBrush bruh ? bruh : new SolidColorBrush(Colors.Transparent);
            }

            private static void ChangeTheme(Uri uri)
            {
                ThemeDictionary = new ResourceDictionary() { Source = uri };
            }
            //public static void SetTheme(ThemeTypes theme)
            //{
            //    string themeName = null;
            //    CurrentTheme = theme;
            //    switch (theme)
            //    {
            //        case ThemeTypes.Dark: themeName = "DarkTheme"; break;
            //        case ThemeTypes.Light: themeName = "LightTheme"; break;
            //        case ThemeTypes.ColourfulDark: themeName = "ColourfulDarkTheme"; break;
            //        case ThemeTypes.ColourfulLight: themeName = "ColourfulLightTheme"; break;
            //    }

            //    try
            //    {
            //        if (!string.IsNullOrEmpty(themeName))
            //            ChangeTheme(new Uri($"Themes/{themeName}.xaml", UriKind.Relative));
            //    }
            //    catch { }
            //}
        }
    
}
