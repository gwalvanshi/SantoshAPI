using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using GEE.Common;
using NLog;

namespace GEE.API.Controllers.Admission
{
    public class EnquiryTypeController : BaseController
    {
        // GET: EnquiryType
        IEnquiryType _iEnquiryType;
        public EnquiryTypeController(IEnquiryType enquiryType)
        {
            _iEnquiryType = enquiryType;
        }
        [Route("admission/enquiry_types")]
        [HttpGet]
        public HttpResponseMessage GetEnquiryType()
        {
            CustomDataResponseModel customResponseModel = new CustomDataResponseModel();
            try
            {
                EnquiryTypeModel objEnquiryTypeModel = new EnquiryTypeModel();
                List<EnquiryTypeModel> objList = new List<EnquiryTypeModel>();
                 objList = _iEnquiryType.GetAll();
               
                if (objList.Count > 0)
                {
                    customResponseModel.type = "success";
                    customResponseModel.message = "";
                    customResponseModel.data = objList;
                }
                else
                {
                    customResponseModel.type = "error";
                    customResponseModel.message = "No records found!";
                    customResponseModel.data = objList;

                }

            }
            catch (Exception ex)
            {
                customResponseModel.type = "error";
                customResponseModel.message = ex.Message;
                customResponseModel.data = null;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, customResponseModel);
            }
            return Request.CreateResponse(HttpStatusCode.OK, customResponseModel);
        }
    }
}