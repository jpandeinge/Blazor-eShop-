using Microsoft.AspNetCore.Components;

namespace Server.Shared
{
    public partial class NavMenu
    {
        [Inject] private NavigationManager NavMan { get; set; }


        protected override void OnInitialized()
        {
            Refresh();
            base.OnInitialized();
        }

        public void Refresh()
        {
            
        }
    }
    
  
}