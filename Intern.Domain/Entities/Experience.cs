using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.Domain.Entities
{
    internal class Experience
    {
        public int ResumeCVid { get; set; }
        public int ExperienceId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }

    }
}
