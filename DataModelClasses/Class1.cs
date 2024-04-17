using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionCommittee.DataModelClasses
{
    public class Applicant
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EducationTypeId { get; set; }
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public string SNILS { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ParentFullName { get; set; }
        public string InstitutionAttended { get; set; }
        public float? DiplomaScore { get; set; }
        public float? CertificateScore { get; set; }
        public float? EgeScore { get; set; }
        public int SpecialtyId { get; set; }
        public string EducationDocumentScan { get; set; }
    }
}
