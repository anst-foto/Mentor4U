using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor4U.Domain
{
     public class Scill
    {
        public int Id { get; set; }

        public int Name {  get; set; }

        public string? Description { get; set; }

        public Mentor Mentor {  get; set; }
    }
}
