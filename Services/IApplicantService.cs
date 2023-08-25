using HR_Help.Models;

namespace HR_Help.Services
{
    public interface IApplicantService
    {
        public Applicant Create(Applicant applicant);
        public Applicant Get(int id);
        public List<Applicant> List();
        public Applicant Update(Applicant applicant);
        public bool Delete(int id);

    }
}
