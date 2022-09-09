using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppExtensions
{
    public class ColorList
    {
        static Dictionary<string, Color> _colors = new Dictionary<string, Color>();
        public static string GetRandomColorHex()
        {
            if (Application.Current.UserAppTheme == AppTheme.Light)
            {
                return GetRandomDarkColor().ToHex();
            }
            return GetRandomLightColor().ToHex();
        }
        public static string GetRandomColorHex(string key)
        {
            if (_colors.ContainsKey(key))
                return _colors[key].ToArgbHex();
            Color color = AppExtension.PrimaryTextColor;
            if (Application.Current.UserAppTheme == AppTheme.Light)
            {
                color = GetRandomDarkColor();
                _colors[key] = color;
            }
            else
            {
                color = GetRandomLightColor();
                _colors[key] = color;
            }

            return color.ToArgbHex();
        }
        //Random Dark Colors `
        public static Color GetRandomDarkColor()
        {
            var solid = Colors.IndianRed;
            Random random = new Random();
            var num = random.Next(1, 48);
            switch (num)
            {
                case 1:
                    solid = Colors.Navy;
                    break;
                case 2:
                    solid = Colors.MidnightBlue;
                    break;
                case 3:
                    solid = Colors.Olive;
                    break;
                case 4:
                    solid = Colors.OrangeRed;
                    break;
                case 5:
                    solid = Colors.OliveDrab;
                    break;
                case 6:
                    solid = Colors.PaleVioletRed;
                    break;
                case 7:
                    solid = Colors.MediumVioletRed;
                    break;
                case 8:
                    solid = Colors.Maroon;
                    break;
                case 9:
                    solid = Colors.MediumBlue;
                    break;
                case 10:
                    solid = Colors.YellowGreen;
                    break;
                case 11:
                    solid = Colors.Purple;
                    break;
                case 12:
                    solid = Colors.Red;
                    break;
                case 13:
                    solid = Colors.SlateBlue;
                    break;
                case 14:
                    solid = Colors.RoyalBlue;
                    break;
                case 15:
                    solid = Colors.Salmon;
                    break;
                case 16:
                    solid = Colors.SeaGreen;
                    break;
                case 17:
                    solid = Colors.Sienna;
                    break;
                case 18:
                    solid = Colors.SaddleBrown;
                    break;
                case 19:
                    solid = Colors.Crimson;
                    break;
                case 20:
                    solid = Colors.DarkCyan;
                    break;
                case 21:
                    solid = Colors.DarkGoldenrod;
                    break;
                case 22:
                    solid = Colors.DarkGreen;
                    break;
                case 23:
                    solid = Colors.DarkMagenta;
                    break;
                case 24:
                    solid = Colors.DarkOliveGreen;
                    break;
                case 25:
                    solid = Colors.DarkOrange;
                    break;
                case 26:
                    solid = Colors.DarkOrchid;
                    break;
                case 27:
                    solid = Colors.DarkRed;
                    break;
                case 28:
                    solid = Colors.CornflowerBlue;
                    break;
                case 29:
                    solid = Colors.Chocolate;
                    break;
                case 30:
                    solid = Colors.Blue;
                    break;
                case 31:
                    solid = Colors.BlueViolet;
                    break;
                case 32:
                    solid = Colors.Brown;
                    break;
                case 33:
                    solid = Colors.DarkSlateBlue;
                    break;
                case 34:
                    solid = Colors.DarkBlue;
                    break;
                case 35:
                    solid = Colors.HotPink;
                    break;
                case 36:
                    solid = Colors.IndianRed;
                    break;
                case 37:
                    solid = Colors.Indigo;
                    break;
                case 38:
                    solid = Colors.DarkSlateGray;
                    break;
                case 39:
                    solid = Colors.Green;
                    break;
                case 40:
                    solid = Colors.DarkViolet;
                    break;
                case 41:
                    solid = Colors.DeepPink;
                    break;
                case 42:
                    solid = Colors.DeepSkyBlue;
                    break;
                case 43:
                    solid = Colors.DodgerBlue;
                    break;
                case 44:
                    solid = Colors.Firebrick;
                    break;
                case 45:
                    solid = Colors.Fuchsia;
                    break;
                case 46:
                    solid = Colors.Goldenrod;
                    break;
                case 47:
                    solid = Colors.Gold;
                    break;
                case 48:
                    solid = Colors.ForestGreen;
                    break;

                default:
                    solid = Colors.IndianRed;
                    break;

            }
            return solid;
        }
        //Get Random Light Colors
        public static Color GetRandomLightColor()
        {
            var solid = Colors.MistyRose;
            Random random = new Random();
            var num = random.Next(1, 37);
            switch (num)
            {
                case 1:
                    solid = Colors.Moccasin;
                    break;
                case 2:
                    solid = Colors.NavajoWhite;
                    break;
                case 3:
                    solid = Colors.PaleGoldenrod;
                    break;
                case 4:
                    solid = Colors.PaleGreen;
                    break;
                case 5:
                    solid = Colors.PaleTurquoise;
                    break;
                case 6:
                    solid = Colors.MediumSpringGreen;
                    break;
                case 7:
                    solid = Colors.LightSkyBlue;
                    break;
                case 8:
                    solid = Colors.LightSteelBlue;
                    break;
                case 9:
                    solid = Colors.LightYellow;
                    break;
                case 10:
                    solid = Colors.MediumTurquoise;
                    break;
                case 11:
                    solid = Colors.Linen;
                    break;
                case 12:
                    solid = Colors.MediumAquamarine;
                    break;
                case 13:
                    solid = Colors.PapayaWhip;
                    break;
                case 14:
                    solid = Colors.Tan;
                    break;
                case 15:
                    solid = Colors.Thistle;
                    break;
                case 16:
                    solid = Colors.Wheat;
                    break;
                case 17:
                    solid = Colors.Turquoise;
                    break;
                case 18:
                    solid = Colors.PeachPuff;
                    break;
                case 19:
                    solid = Colors.SkyBlue;
                    break;
                case 20:
                    solid = Colors.Pink;
                    break;
                case 21:
                    solid = Colors.Plum;
                    break;
                case 22:
                    solid = Colors.PowderBlue;
                    break;
                case 23:
                    solid = Colors.RosyBrown;
                    break;
                case 24:
                    solid = Colors.LightSalmon;
                    break;
                case 25:
                    solid = Colors.LightGreen;
                    break;
                case 26:
                    solid = Colors.LightPink;
                    break;
                case 27:
                    solid = Colors.Aqua;
                    break;
                case 28:
                    solid = Colors.Aquamarine;
                    break;
                case 29:
                    solid = Colors.Bisque;
                    break;
                case 30:
                    solid = Colors.Coral;
                    break;
                case 31:
                    solid = Colors.BurlyWood;
                    break;
                case 32:
                    solid = Colors.CadetBlue;
                    break;
                case 33:
                    solid = Colors.DarkTurquoise;
                    break;
                case 34:
                    solid = Colors.Khaki;
                    break;
                case 35:
                    solid = Colors.Lavender;
                    break;
                case 36:
                    solid = Colors.LavenderBlush;
                    break;
                case 37:
                    solid = Colors.LightBlue;
                    break;
                default:
                    solid = Colors.Coral;
                    break;
            }
            return solid;
        }
        static List<Color> list = null;
        public static List<Color> GetColors()
        {
            if (list != null)
                return list;
            if (list == null)
                list = new List<Color>();
            list.Add(Colors.MistyRose);
            list.Add(Colors.Moccasin);
            list.Add(Colors.NavajoWhite);
            list.Add(Colors.PaleGoldenrod);
            list.Add(Colors.PaleGreen);
            list.Add(Colors.PaleTurquoise);
            list.Add(Colors.MediumSpringGreen);
            list.Add(Colors.LightSkyBlue);
            list.Add(Colors.LightSteelBlue);
            list.Add(Colors.LightYellow);
            list.Add(Colors.MediumTurquoise);
            list.Add(Colors.Linen);
            list.Add(Colors.MediumAquamarine);
            list.Add(Colors.PapayaWhip);
            list.Add(Colors.Tan);
            list.Add(Colors.Thistle);
            list.Add(Colors.Wheat);
            list.Add(Colors.Turquoise);
            list.Add(Colors.PeachPuff);
            list.Add(Colors.SkyBlue);
            list.Add(Colors.Pink);
            list.Add(Colors.Plum);
            list.Add(Colors.PowderBlue);
            list.Add(Colors.RosyBrown);
            list.Add(Colors.SkyBlue);
            list.Add(Colors.LightSalmon);
            list.Add(Colors.LightGreen);
            list.Add(Colors.LightPink);
            list.Add(Colors.Aqua);
            list.Add(Colors.Aquamarine);
            list.Add(Colors.Bisque);
            list.Add(Colors.Coral);
            list.Add(Colors.BurlyWood);
            list.Add(Colors.CadetBlue);
            list.Add(Colors.DarkTurquoise);
            list.Add(Colors.Khaki);
            list.Add(Colors.Lavender);
            list.Add(Colors.LavenderBlush);
            list.Add(Colors.LightBlue);
            list.Add(Colors.Coral);
            list.Add(Colors.Navy);
            list.Add(Colors.MidnightBlue);
            list.Add(Colors.Olive);
            list.Add(Colors.OrangeRed);
            list.Add(Colors.OliveDrab);
            list.Add(Colors.PaleVioletRed);
            list.Add(Colors.MediumVioletRed);
            list.Add(Colors.Maroon);
            list.Add(Colors.MediumBlue);
            list.Add(Colors.YellowGreen);
            list.Add(Colors.Purple);
            list.Add(Colors.Red);
            list.Add(Colors.SlateBlue);
            list.Add(Colors.RoyalBlue);
            list.Add(Colors.Salmon);
            list.Add(Colors.SeaGreen);
            list.Add(Colors.Sienna);
            list.Add(Colors.SaddleBrown);
            list.Add(Colors.Crimson);
            list.Add(Colors.DarkCyan);
            list.Add(Colors.DarkGoldenrod);
            list.Add(Colors.DarkGreen);
            list.Add(Colors.DarkMagenta);
            list.Add(Colors.DarkOliveGreen);
            list.Add(Colors.DarkOrange);
            list.Add(Colors.DarkOrchid);
            list.Add(Colors.DarkRed);
            list.Add(Colors.CornflowerBlue);
            list.Add(Colors.Chocolate);
            list.Add(Colors.Blue);
            list.Add(Colors.BlueViolet);
            list.Add(Colors.Brown);
            list.Add(Colors.DarkSlateBlue);
            list.Add(Colors.DarkBlue);
            list.Add(Colors.HotPink);
            list.Add(Colors.IndianRed);
            list.Add(Colors.Indigo);
            list.Add(Colors.DarkSlateGray);
            list.Add(Colors.Green);
            list.Add(Colors.DarkViolet);
            list.Add(Colors.DeepPink);
            list.Add(Colors.DeepSkyBlue);
            list.Add(Colors.DodgerBlue);
            list.Add(Colors.Firebrick);
            list.Add(Colors.Fuchsia);
            list.Add(Colors.Goldenrod);
            list.Add(Colors.Gold);
            list.Add(Colors.ForestGreen);

            var orderedColorList = list.OrderBy(color => color.GetHue()).ThenBy(o => o.Red * 3 + o.Green * 2 + o.Blue * 1);
            list = orderedColorList.ToList();
            return list;
        }
    }
}