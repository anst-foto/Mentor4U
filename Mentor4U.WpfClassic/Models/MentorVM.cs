using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;


namespace Mentor4U.WpfClassic.Models
{
    public class MentorVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Description { get; set; }


        public string PhotoPath { get; set; }

        public  File 
    }
}
