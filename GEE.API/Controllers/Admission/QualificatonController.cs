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
    public class QualificatonController : BaseController
    {
        // GET: Qualificaton
        IQualificaton _iQualificaton;
        public QualificatonController(IQualificaton qualificaton)
        {
            _iQualificaton = qualificaton;
        }
        [Route("admission/qualifications")]
        [HttpGet]
        public HttpResponseMessage GetQualificaton()
        {
            CustomDataResponseModel customResponseModel = new CustomDataResponseModel();
            try
            {
                QualificatonModel objQualificatonModel = new QualificatonModel();
                List<QualificatonModel> objList = new List<QualificatonModel>();
                 objList = _iQualificaton.GetAll();
               
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