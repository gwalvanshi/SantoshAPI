using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GEE.Business.Models.Admission;
using GEE.DataAccess;

namespace GEE.Business.Manager
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Enquiry, EnquiryModel>().ReverseMap();
                config.CreateMap<ClassMaster, ClassesModel>().ReverseMap();
                config.CreateMap<AcademicYear, AcademicYearModel>().ReverseMap();
                config.CreateMap<CastCategory, CastCategoryModel>().ReverseMap();
                config.CreateMap<Qualificaton, QualificatonModel>().ReverseMap();
                config.CreateMap<EnquiryType, EnquiryTypeModel>().ReverseMap();
                config.CreateMap<tblUnit, UnitModel>().ReverseMap();
                config.CreateMap<tblSize, SizeModel>().ReverseMap();
                config.CreateMap<Application, ApplicationModel>().ReverseMap();
                config.CreateMap<CandidateDetail, CandidateDetailModel>().ReverseMap();
                config.CreateMap<DocumentSubmission, DocumentSubmissionModel>().ReverseMap();
                config.CreateMap<Registration, RegistrationModel>().ReverseMap();
               config.CreateMap<MarketingSource, MarketingSourceModel>().ReverseMap();

            });
        }

    }
}
