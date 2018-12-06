using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GEE.DataAccess;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using AutoMapper;
using System.Linq;
using GEE.Business.Interface;

namespace GEE.Business.Manager.Admission
{
    public class EnquiryTypeManager : IEnquiryType
    {
        IMyDataAccess<EnquiryType> _enquiryTypeAccess = new MyDataAccess<EnquiryType>();
        public void Delete(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public List<EnquiryTypeModel> GetAll()
        {
            var enquiryTypeList = _enquiryTypeAccess.GetAll();
            List<EnquiryTypeModel> enquiryTypeModellList = new List<EnquiryTypeModel>();
            foreach (var item in enquiryTypeList)
            {
                enquiryTypeModellList.Add(Mapper.Map<EnquiryTypeModel>(item));

            }
            return enquiryTypeModellList;
        }

        public Task<List<EnquiryTypeModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public EnquiryTypeModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EnquiryTypeModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public EnquiryTypeModel Save(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<EnquiryTypeModel> SaveAsync(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public EnquiryTypeModel Update(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<EnquiryTypeModel> UpdateAsync(EnquiryTypeModel entity)
        {
            throw new NotImplementedException();
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
        // ~EnquiryTypeManager() {
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
