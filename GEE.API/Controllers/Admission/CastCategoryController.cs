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
    public class CastCategoryController : BaseController
    {
        // GET: CastCategory
        ICastCategory _iCastCategory;
        public CastCategoryController(ICastCategory castCategory)
        {
            _iCastCategory = castCategory;
        }
        [Route("Admission/CastCategory")]
        [HttpGet]
        public HttpResponseMessage GetCastCategory()
        {
            CustomDataResponseModel customResponseModel = new CustomDataResponseModel();
            try
            {
                List<CastCategoryModel> objList = new List<CastCategoryModel>();
                objList = _iCastCategory.GetAll();
               
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