using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppExtensions
{
    public class ViewHelper
    {
        public async static void Tapped(ContentView view)
        {

            var cColor = view.BackgroundColor;
            view.BackgroundColor = Application.AccentColor;
            view.Opacity = 0.4;
            await Task.Delay(100);
            view.Opacity = 10;
            view.BackgroundColor = Colors.Transparent;

        }
        public async static void Tapped(View view)
        {

            var cColor = view.BackgroundColor;
            view.BackgroundColor = Application.AccentColor;
            view.Opacity = 0.4;
            await Task.Delay(100);
            view.Opacity = 10;
            view.BackgroundColor = cColor;

        }
        public async static void Tapped(ContentView view, Color normalColor)
        {

            view.BackgroundColor = Application.AccentColor;
            view.Opacity = 0.4;
            await Task.Delay(100);
            view.Opacity = 10;
            view.BackgroundColor = normalColor;

        }
        static Color _normalColor = Application.AccentColor;
        public async static void Tapped(Grid view, Color normalColor)
        {
            _normalColor = normalColor;
            view.BackgroundColor = Application.AccentColor;
            view.Opacity = 0.4;
            await Task.Delay(100);
            view.Opacity = 10;
            view.BackgroundColor = _normalColor;

        }
        public async static void Tapped(View view, Color normalColor)
        {
            _normalColor = normalColor;
            view.BackgroundColor = Application.AccentColor;
            view.Opacity = 0.4;
            await Task.Delay(100);
            view.Opacity = 10;
            view.BackgroundColor = _normalColor;

        }
    }
}
