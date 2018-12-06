using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GEE.DataAccess;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using AutoMapper;
using System.Linq;
using GEE.Business.Interface;
using GEE.DataAccess.Admission;
namespace GEE.Business.Manager.Admission
{
    public class UnitManager : IUnit
    {
        IMyDataAccess<tblUnit> _unitDataAccess = new MyDataAccess<tblUnit>();
       // IMyDataAccess<tblSize> _tblSize = new MyDataAccess<tblSize>();
      //  UnitDataAccess objUnitDataAccess = new UnitDataAccess();

        public UnitModel Save(UnitModel entity)
        {
            var enquiry = _unitDataAccess.Save(Mapper.Map<tblUnit>(entity));
            //Sam Commented this
            //foreach (var item in entity.tblSizes)
            //{
            //    item.UnitID = enquiry.UnitID;
            //    var size = _tblSize.SaveAsync(Mapper.Map<tblSize>(item));
            //}
            //Sam Ends
            return new UnitModel { UnitID = enquiry.UnitID };
        }

        public async Task<UnitModel> SaveAsync(UnitModel entity)
        {
            var enquiry = await _unitDataAccess.SaveAsync(Mapper.Map<tblUnit>(entity));        


            return new UnitModel { UnitID = enquiry.UnitID };
        }

        public void Delete(UnitModel entity)
        {
            _unitDataAccess.Delete(entity.UnitID);
        }

        public async Task DeleteAsync(UnitModel entity)
        {
            await _unitDataAccess.DeleteAsync(entity.UnitID);
        }

        public List<UnitModel> GetAll()
        {
            //Sam
            var enquiryList1 = _unitDataAccess.GetAll(x => x.tblSizes);
            
            // var enquiryList = objUnitDataAccess.GetAllUnit();
            //List<UnitModel> enquiryModelList = new List<UnitModel>();

            //This is added for Automapper list: no need to run the loop
            var enquiryModelList = Mapper.Map<IEnumerable<tblUnit>, IEnumerable<UnitModel>>(enquiryList1).ToList();

            // Sam Ends

            //foreach (var item in enquiryList)
            //{
            //    enquiryModelList.Add(Mapper.Map<UnitModel>(item));

            //}

            return enquiryModelList;
        }

        public async Task<List<UnitModel>> GetAllAsync()
        {
            var enquiryList = await _unitDataAccess.GetAllAsync();
            List<UnitModel> enquiryModelList = new List<UnitModel>();
            foreach (var item in enquiryList)
            {
                enquiryModelList.Add(Mapper.Map<UnitModel>(item));

            }
            return enquiryModelList;
        }

        public async Task<UnitModel> GetByIdAsync(int id)
        {
            return Mapper.Map<UnitModel>(await _unitDataAccess.GetByIdAsync(id));
        }

        public UnitModel GetById(int id)
        {
            var enquiry = _unitDataAccess.GetById(id);
            return Mapper.Map<UnitModel>(enquiry);
        }

        public UnitModel Update(UnitModel entity)
        {
            var enquiry = _unitDataAccess.Update(Mapper.Map<tblUnit>(entity));
            return new UnitModel { UnitID = enquiry.UnitID };
        }

        public async Task<UnitModel> UpdateAsync(UnitModel entity)
        {
            var enquiry = await _unitDataAccess.UpdateAsync(Mapper.Map<tblUnit>(entity));
            return new UnitModel { UnitID = enquiry.UnitID };
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitManager() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
