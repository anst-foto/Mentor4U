using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Mentor4U.Domain;
using Microsoft.AspNetCore.Components.Forms;


namespace Mentor4U.WpfClassic.Models
{
    public class MentorVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Имя обязательно")]
        [MaxLength(100),MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Фамилия обязательно")]
        [MaxLength(100),MinLength(3)]
        public string LastName { get; set; }

        public string Description { get; set; }


        public string PhotoPath { get; set; }

        

        [Required]
        [EmailAddress(ErrorMessage = "Неверный формат")]
        public string Email { get; set; }

        [Required]
        [Phone(ErrorMessage ="Неверный формат")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("Выберите дату рождения")]
        public DateTime BirthDay { get; set; }

        [Required]
        [DisplayName("Выберите дату начала деятельности")]
        public DateTime ActivityStart { get; set; }

        [Required]
        public string Scill {  get; set; }

        public TimeSpan Age 
        {
            get => Age;
            set => Age= DateTime.Now-BirthDay;
        }
        public TimeSpan Expiriens 
        {
            get => Expiriens;
            set => Expiriens = DateTime.Now - ActivityStart;
        }

        public MentorVM()
        {
                
        }
        public MentorVM(Mentor dto)
        {
             Id= dto.Id;
            Name = dto.Name;
            LastName= dto.LastName;
            Description = dto.Description;
            Phone = dto.PhoneNumber;
            BirthDay = dto.BirthDay;
            ActivityStart = dto.ActivityStart;
            Email = dto.Email;
            PhotoPath= dto.PhotoPath;
            Scill= dto.Scill;
        }
    }
}
