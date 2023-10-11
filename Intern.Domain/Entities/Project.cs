using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.Domain.Entities
{
    internal class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string ProjectDescription { get; set; }
        public string TechStack { get; set; }
    }
}
