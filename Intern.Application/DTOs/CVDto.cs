using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.Application.DTOs
{
    internal class CVDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } // string because of the format
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public string Languages { get; set; }
    }

}
