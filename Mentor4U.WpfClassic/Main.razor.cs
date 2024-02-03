using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Mentor4U.WpfClassic
{
    public partial class Main

    {

        public bool ShowAdmin { get; set; } = false;

        public void RoadToAdmin()
        {
            navManager.NavigateTo("/admin");
        }
        public void ShowingAdmin()
        {
            ShowAdmin = !ShowAdmin;
        }
    }
}
