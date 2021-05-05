using Microsoft.AspNetCore.Components;

namespace Server.Shared
{
    public partial class NavMenu
    {
        [Inject] private NavigationManager NavMan { get; set; }
        
        // [Inject] private IMenuService MenuService { get; set; }

        //sections are "getting-started", "components", "api", ...
        private string _section;
        
        //component links are the part of the url that tells us what component is featured
        string _componentLink;

        protected override void OnInitialized()
        {
            Refresh();
            base.OnInitialized();
        }

        public void Refresh()
        {
            // _section = NavMan.GetSection();
            // _componentLink = NavMan.GetComponentLink();
            StateHasChanged();
        }
    }
    
  
}