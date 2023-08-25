using HR_Help.Models;
using HR_Help.Repositories;

namespace HR_Help.Services
{
    public class ApplicantService : IApplicantService
    {
        public Applicant Create(Applicant applicant)
        {
            applicant.id = ApplicantReository.Applicants.Count + 1;
            ApplicantReository.Applicants.Add(applicant);

            return applicant;
        }

        public Applicant Get(int id)
        {
            var applicant = ApplicantReository.Applicants.FirstOrDefault(o => o.id == id);
            
            if (applicant == null) return null;

            return applicant;
        }

        public List<Applicant> List()
        {
            var applicants = ApplicantReository.Applicants;

            return applicants;
        }

        public Applicant Update(Applicant newApplicant)
        {
            var oldApplicant = ApplicantReository.Applicants.FirstOrDefault(o => o.id == newApplicant.id);
            
            if (oldApplicant is null) return null;

            oldApplicant.firstName = newApplicant.firstName;
            oldApplicant.lastName = newApplicant.lastName;
            oldApplicant.workExperience = newApplicant.workExperience;
            oldApplicant.emailAddress = newApplicant.emailAddress;
            oldApplicant.phoneNumber = newApplicant.phoneNumber;
            oldApplicant.description = newApplicant.description;

            return newApplicant;
        }
        public bool Delete(int id) 
        {
            var oldApplicant = ApplicantReository.Applicants.FirstOrDefault(o => o.id == id);

            if (oldApplicant is null) return false;

            ApplicantReository.Applicants.Remove(oldApplicant);

            return true;
        }
    }
}
