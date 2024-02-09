using Mentor4U.WpfClassic.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;








namespace Mentor4U.WpfClassic
{
    public partial class Main

    {
        private IBrowserFile File;

        private bool IsLoading;

        private long maxFileSize = 1024 * 15;
        public bool CanShowAdmin { get; set; } = false;

        public bool CanShowSearch { get; set; } = false;

        public bool CanShowBegin { get; set; } = false;

        public int AdminChoice { get; set; }

        public string Search { get; set; }

        public bool VMDetails { get; set; }

        public MentorVM VM { get; set; } = new();

        public List<MentorVM> VMs { get; set; }

        public void ShowAdmin()
        {
            CanShowAdmin = !CanShowAdmin;
            CanShowSearch = false;
            CanShowBegin = false;
        }
        public void ShowSearch()
        {
            CanShowAdmin = false;
            CanShowSearch = !CanShowSearch;
            CanShowBegin = false;
        }
        public void ShowBegin()
        {
            CanShowAdmin = false;
            CanShowSearch = false;
            CanShowBegin = !CanShowBegin;
        }
        public void FirstChoice() => AdminChoice = 1;

        public void SecondChoice() => AdminChoice = 2;

        public void ThirdChoice() => AdminChoice = 3;


        protected override void OnInitialized()
        {
            VMs = Repository.GetAll().Select(x => new MentorVM(x)).ToList();
        }
        public void DeleteClick(MentorVM vm)
        {
            var dto = Mapper.MapToDTO(vm);
            Repository.Delete(dto);
        }
        public void SubmitClick(MentorVM vm)
        {
            var dto = Mapper.MapToDTO(vm);
            Repository.Add(dto);
        }
        public void ShowVMDetails()
        {
            VMDetails = !VMDetails;
        }



    }
}