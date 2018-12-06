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
    public class QualificatonManager : IQualificaton
    {
        IMyDataAccess<Qualificaton> _enquiryDataAccess = new MyDataAccess<Qualificaton>();
        public void Delete(QualificatonModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(QualificatonModel entity)
        {
            throw new NotImplementedException();
        }

        public List<QualificatonModel> GetAll()
        {
            var qualificatonList = _enquiryDataAccess.GetAll();
            List<QualificatonModel> qualificatonModelList = new List<QualificatonModel>();
            foreach (var item in qualificatonList)
            {
                qualificatonModelList.Add(Mapper.Map<QualificatonModel>(item));

            }
            return qualificatonModelList;
        }

        public Task<List<QualificatonModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public QualificatonModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QualificatonModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public QualificatonModel Save(QualificatonModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<QualificatonModel> SaveAsync(QualificatonModel entity)
        {
            throw new NotImplementedException();
        }

        public QualificatonModel Update(QualificatonModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<QualificatonModel> UpdateAsync(QualificatonModel entity)
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
        // ~QualificatonManager() {
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
