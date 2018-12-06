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
using System.Net.Http.Formatting;
using Newtonsoft.Json.Linq;

namespace GEE.API.Controllers.Admission
{
    public class UnitController : BaseController
    {
        IUnit _unit;
        public UnitController(IUnit unit)
        {
            _unit = unit;
        }

        [Route("admission/unit")]
        [HttpPost]
        public HttpResponseMessage SaveUnit([FromBody]JObject data)
        {
            CustomResponseModel customResponseModel = new CustomResponseModel();
            try
            {
                string Name = data["Name"].ToObject<string>();
                string Description = data["Description"].ToObject<string>();
                string SizeName = data["SizeName"].ToObject<string>();
                string SizeDescription = data["SizeDescription"].ToObject<string>();

                SizeModel _sizeModel = new SizeModel();
                List<SizeModel> _sizeModelList = new List<SizeModel>();
                _sizeModel.SizeName = SizeName;
                _sizeModel.SizeDescription = SizeDescription;
                _sizeModelList.Add(_sizeModel);
                UnitModel _unitModel = new UnitModel
                {
                    Name = Name,
                    Description = Description,
                    //  tblSizes= _sizeModelList
                };
                _unitModel.tblSizes.Add(_sizeModel);

                _unit.Save(_unitModel);

                customResponseModel.type = "success";
                customResponseModel.message = "Enquiry Submitted";
                // customResponseModel.data = objList;

            }
            catch (Exception ex)
            {
                customResponseModel.type = "error";
                customResponseModel.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, customResponseModel);
            }
            return Request.CreateResponse(HttpStatusCode.OK, customResponseModel);
        }


        //Sam : Test method to save data
        [Route("admission/saveunit")]
        [HttpGet]
        public HttpResponseMessage SaveUnitSam()
        {
            CustomResponseModel customResponseModel = new CustomResponseModel();
            try
            {
                string Name = "Test Name - SAM 2";
                string Description = "Test Description - SAM 2";
                string SizeName = "Size Name - SAM 2";
                string SizeDescription = "Size Desc - SAM 2";

                SizeModel _sizeModel = new SizeModel();
                List<SizeModel> _sizeModelList = new List<SizeModel>();
                _sizeModel.SizeName = SizeName;
                _sizeModel.SizeDescription = SizeDescription;
                _sizeModelList.Add(_sizeModel);
                UnitModel _unitModel = new UnitModel
                {
                    Name = Name,
                    Description = Description,
                    tblSizes = _sizeModelList
                };
                // _unitModel.tblSizes.Add(_sizeModel);

                _unit.Save(_unitModel);

                customResponseModel.type = "success";
                customResponseModel.message = "Enquiry Submitted";
                // customResponseModel.data = objList;
            }
            catch (Exception ex)
            {
                customResponseModel.type = "error";
                customResponseModel.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, customResponseModel);
            }
            return Request.CreateResponse(HttpStatusCode.OK, customResponseModel);
        }

        //Sam Ends

        [Route("admission/unit")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            CustomDataResponseModel customResponseModel = new CustomDataResponseModel();
            try
            {
                UnitModel objEnquiryModel = new UnitModel();
                List<UnitModel> objList = new List<UnitModel>();
                objList = _unit.GetAll();

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