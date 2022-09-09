using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppExtensions
{
    public class Navigator
    {
        
        string _currentPage = "/";
        string _homePage { get; set; } = "/";
        NavigationManager Navigation { get; set; }
        IJSRuntime JS { get; set; }
        public void SetNavigation(NavigationManager navigation, IJSRuntime js, string dfaultPage = "/")
        {
            this.Navigation = navigation;
            this.JS = js;
            _currentPage = dfaultPage;
            _homePage = _currentPage;
        }
        public Navigator()
        {
            
        }
        public Stack<string> Navigators = new Stack<string>();
        public void NavigateTo(string parameter)
        {
            if (parameter != _currentPage)
            {
                Navigators.Push(parameter);
                Navigation?.NavigateTo(parameter);
                _currentPage = parameter;
            }
        }
        public async void ExecuteCommand(NavigateType code, string param)
        {
            if (code ==  NavigateType.Back)
            {
                if (Navigators.Count >= 1)
                {
                    string nav = null;
                    if(Peek() == param)
                        Navigators.Pop();
                    if(Navigators.Count >=1)
                      nav = Navigators.Pop();
                    if (nav != null)
                        _currentPage = nav;
                    else
                    {
                        _currentPage = _homePage;
                    }
                    await JS.InvokeVoidAsync("history.back");
                    BackPressed?.Invoke(this, nav);
                }
                else
                {
                   
                    _currentPage = _homePage;
                    await JS.InvokeVoidAsync("history.back");
                    BackPressed?.Invoke(this, null);
                   
                }
                
            }
            else if (code == NavigateType.Navigate)
            {
                if (param != _currentPage)
                {
                    _currentPage = param;
                    Navigators.Push(param);
                    Navigation?.NavigateTo(param);
                    Navigated?.Invoke(this, param);
                }

            }
        }
        public string Peek()
        {
            return Navigators.Peek();
        }
        public string Pop()
        {
            return Navigators.Pop();
        }
        public event EventHandler<string> BackPressed;
        public event EventHandler<string> Navigated;
    }
    public enum NavigateType
    {
        Navigate,
        Back,

    }
    public static class NavStrings
    {
        public const string NOTE_BOOK = "notebook";
        public const string HOME = "home";
        public const string RENDER = "render";
        public const string BOOK_MARKS = "bookmarks";
        public const string HIGH_LIGHTS = "highlights";
        public const string TRANSLATIONS = "translations";
        public const string SEARCH = "search";
        public const string READ_ALL_ALOUD = "read-aloud";
        public const string VIEW_HTML = "view-html";
        public const string SPLIT_VIEW = "split-view";
        public const string SELECT_BOOK = "select-book";
        public const string TEXT_HIGHLIGHTS = "text-highlights";
        public const string EXTRAS_BACKUP = "extras & backup";
        public const string NEED_HELP = "need help";
        public const string SETTINGS = "settings";
        public const string SUPPORT = "support";
        public const string WORSHIPS = "worship songs";
        public const string TESTIMONIES = "testimonies";
        public const string PRIVACY = "privacy";
        public const string LOVE = "love";

    }
}
