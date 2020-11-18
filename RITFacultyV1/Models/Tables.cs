using System.Collections.Generic;

namespace RITFacultyV1.Models
{
    public class CoopInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string term { get; set; }
    }
    public class CoopTable
    {
        public string title { get; set; }
        public List<CoopInformation> coopInformation { get; set; }
    }

    public class ProfessionalEmploymentInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
    }

    public class EmploymentTable
    {
        public string title { get; set; }
        public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
    }

    public class Tables
    {
        public CoopTable coopTable { get; set; }
        public EmploymentTable employmentTable { get; set; }
    }
}
