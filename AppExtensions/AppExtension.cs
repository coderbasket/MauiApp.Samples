using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppExtensions
{
    public static class AppExtension
    {
        public static string ZoomPixels = "100%";
        public static string ZoomBarPixels = "95%";
        public static string ZoomBottomBarPixels = "75%";
        public static string ZoomFontsize = "100%";
        public static string DialogMaxWidth = "400px";
        public static bool IsMobileWidth = false;

        public static Color SystemAccentColor = Application.AccentColor == null ? Color.FromArgb("#cc9966") : Application.AccentColor;
        public static string AccentRGBA = "";
        public static Color PageBackgroundColor = null;
        public static Color NavigationBarColor = Colors.Teal;
        public static Color PrimaryColor = null;
        public static Color SecondaryColor = null;
        public static Color PrimaryTextColor = Colors.Black;
        public static Color SecondaryTextColor = null;
        public static Color TertiaryTextColor = null;
        public static Color TransparentColor = null;
        public static string PrimaryTextColorOpacity = null;
        
        public static void AddHelper(this Application application)
        {
            var themeTxt = Preferences.Get(nameof(AppTheme), application.RequestedTheme.ToString().ToLower());
            var theme =  themeTxt == "light" ? AppTheme.Light : AppTheme.Dark;
            if (Application.AccentColor == null)
                Application.AccentColor = SystemAccentColor;
            application.UserAppTheme = (AppTheme)theme;
            if (theme == AppTheme.Light)
            {
                Application.Current.Resources["PageBackgroundColor"] = Colors.White;
                Application.Current.Resources["NavigationBarColor"] = Colors.WhiteSmoke;
                Application.Current.Resources["PrimaryColor"] = SystemAccentColor;//Colors.WhiteSmoke;
                Application.Current.Resources["SecondaryColor"] = Colors.Black;
                Application.Current.Resources["PrimaryTextColor"] = Colors.Black;
                Application.Current.Resources["SecondaryTextColor"] = Colors.White;
                Application.Current.Resources["TertiaryTextColor"] = Colors.Gray;
                Application.Current.Resources["TransparentColor"] = Colors.Transparent;
            }
            else
            {
                Application.Current.Resources["PageBackgroundColor"] = Colors.Black;
                Application.Current.Resources["NavigationBarColor"] = Color.FromArgb("#191714");
                Application.Current.Resources["PrimaryColor"] = SystemAccentColor;//Color.FromArgb("#191714");
                Application.Current.Resources["SecondaryColor"] = Colors.White;
                Application.Current.Resources["PrimaryTextColor"] = Colors.White;
                Application.Current.Resources["SecondaryTextColor"] = Colors.White;
                Application.Current.Resources["TertiaryTextColor"] = Colors.WhiteSmoke;
                Application.Current.Resources["TransparentColor"] = Colors.Transparent;
            }
            PageBackgroundColor = Application.Current.Resources["PageBackgroundColor"] as Color;
            NavigationBarColor = Application.Current.Resources["NavigationBarColor"] as Color;
            PrimaryColor = Application.Current.Resources["PrimaryColor"] as Color;
            SecondaryColor = Application.Current.Resources["SecondaryColor"] as Color;
            PrimaryTextColor = Application.Current.Resources["PrimaryTextColor"] as Color;
            SecondaryTextColor = Application.Current.Resources["SecondaryTextColor"] as Color;
            TertiaryTextColor = Application.Current.Resources["TertiaryTextColor"] as Color;
            TransparentColor = Application.Current.Resources["TransparentColor"] as Color;

            AccentRGBA = SystemAccentColor.Red + "," + SystemAccentColor.Green + "," + SystemAccentColor.Blue;
            PrimaryTextColorOpacity = theme == AppTheme.Light ? "rgba(0, 0, 0, 0.9)" : "rgba(255, 255, 255, 0.9)";
           
        }
        public static event EventHandler<Page> NavigateToEvent;
        public static void NavigateBetweenMainPage(Page current, Page to)
        {
            NavigateToEvent(current, to);
        }
        
    }
}
