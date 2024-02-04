using Mentor4U.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.WpfClassic.Models
{
    public static class Mapper
    {
        public static Mentor MapToDTO(MentorVM vm)
        {
            var dto = new Mentor
            {
               
                Name = vm.Name,
                LastName = vm.LastName,
                Scill = vm.Scill,
                Description = vm.Description,
                BirthDay = vm.BirthDay,
                ActivityStart = vm.ActivityStart,
                Email = vm.Email,
                PhoneNumber = vm.Phone,
                PhotoPath = vm.PhotoPath,
            };
            return dto;
        }


    }
}
