using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.Domain.Entities
{
    internal class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string Certifications { get; set; }
        public Skill() { }
        public Skill(string skillName, string skillLevel, string certifications)
        {
            SkillName = skillName;
            SkillLevel = skillLevel;
            Certifications = certifications;
        }
    }
}
