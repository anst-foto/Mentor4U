using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.Domain
{
    public class Mentor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhotoPath { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime ActivityStart { get; set; }

        public string Description { get; set; }

        public List<Scill> Scills { get; set; }
    }
}
