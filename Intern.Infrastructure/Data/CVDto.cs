namespace InternIngressInternal.Intern.Infrastructure.Data
{
    public class CVDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ProfilePicture { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }

        public string[] Skills { get; set; }
        public string[] Languages { get; set; }
        public string[] Interests { get; set; }
        public string[] Hobbies { get; set; }
        public string[] References { get; set; }

        public EducationDto[] Education { get; set; }
        public ExperienceDto[] Experience { get; set; }
        public ProjectDto[] Projects { get; set; }  
        public CertificationDto[] Certifications { get; set; }
        public AwardDto[] Awards { get; set; }
        public PublicationDto[] Publications { get; set; }
        public CourseDto[] Courses { get; set; }
        public VolunteerDto[] Volunteer { get; set; }

    }
}
