using System;
using Microsoft.AspNetCore.Components;
using MudBlazor;



namespace Server.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        private bool _drawerOpen = false;
        private bool _rightToLeft = false;
        private NavMenu _navMenuRef;

        private string _themeIcon  ;
        
        [Inject] private NavigationManager NavigationManager { get; set; }

      
        

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        private void Search(string text)
        {
            if(string.IsNullOrWhiteSpace(text)) 
                
            {return;}
               
        }

        protected override void OnInitialized()
        {
            _currentTheme = _defaultTheme;
            _themeIcon =  "fas fa-sun";
        }


        private void OnSwipe(SwipeDirection direction)
        {
            if (direction == SwipeDirection.LeftToRight && !_drawerOpen)
            {
                _drawerOpen = true;
                StateHasChanged();
            }else if (direction == SwipeDirection.RightToLeft && _drawerOpen)
            {
                _drawerOpen = false;
                StateHasChanged();
            }
        }

        #region Theme
        private void DarkMode()
        {
            if (_currentTheme == _defaultTheme)
            {
                _currentTheme = _darkTheme;
                _themeIcon = "fas fa-moon";
            }
            else
            {
                _currentTheme = _defaultTheme;
                _themeIcon = "fas fa-sun";
            }
        }

        private MudTheme _currentTheme = new MudTheme();
        private readonly MudTheme _defaultTheme =
            new MudTheme()
            {
                Palette = new Palette()
                {
                    Black = "#272c34"
                }
            };
        private readonly MudTheme _darkTheme =
            new MudTheme()
            {
                Palette = new Palette()
                {
                    Black = "#27272f",
                    Background = "#32333d",
                    BackgroundGrey = "#27272f",
                    Surface = "#373740",
                    DrawerBackground = "#27272f",
                    DrawerText = "rgba(255,255,255, 0.50)",
                    AppbarBackground = "#27272f",
                    AppbarText = "rgba(255,255,255, 0.70)",
                    TextPrimary = "rgba(255,255,255, 0.70)",
                    TextSecondary = "rgba(255,255,255, 0.50)",
                    ActionDefault = "#adadb1",
                    ActionDisabled = "rgba(255,255,255, 0.26)",
                    ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                    DrawerIcon = "rgba(255,255,255, 0.50)"
                }
            };

        #endregion
    }
}