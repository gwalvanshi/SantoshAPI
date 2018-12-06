using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.Business.Models.Admission
{
    public class EnquiryModel : BaseEntity
    {
        public int Enquiry_ID { get; set; }
        public string EnquiryNo { get; set; }
        public int? MarketSource_ID { get; set; }
        public int? EnquiryType_ID { get; set; }
        public string Status { get; set; }
        public int? Sessionyear { get; set; }

        public EnquiryTypeModel EnquiryType { get; set; }
        public MarketingSourceModel MarketingSource { get; set; }

        public ICollection<ApplicationModel> Applications { get; set; }
        public ICollection<CandidateDetailModel> CandidateDetails { get; set; }
        public ICollection<DocumentSubmissionModel> DocumentSubmissions { get; set; }
        public ICollection<RegistrationModel> Registrations { get; set; }

    }
}
