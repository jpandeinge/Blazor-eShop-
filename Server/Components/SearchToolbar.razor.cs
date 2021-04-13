﻿using Microsoft.AspNetCore.Components;

namespace Server.Components
{
    public partial class SearchToolbar : ComponentBase
    {
        private string searchString = null;

        public void OnSearch(string text)
        {
            searchString = text;
        }
    }
}