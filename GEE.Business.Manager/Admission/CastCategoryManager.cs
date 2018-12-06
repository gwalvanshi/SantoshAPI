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
    public class CastCategoryManager : ICastCategory
    {
        IMyDataAccess<CastCategory> _castCategoryyDataAccess = new MyDataAccess<CastCategory>();

        public void Delete(CastCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CastCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public List<CastCategoryModel> GetAll()
        {
            var castCategoryList = _castCategoryyDataAccess.GetAll();
            List<CastCategoryModel> castCategoryrModellList = new List<CastCategoryModel>();
            foreach (var item in castCategoryList)
            {
                castCategoryrModellList.Add(Mapper.Map<CastCategoryModel>(item));

            }
            return castCategoryrModellList;
        }

        public Task<List<CastCategoryModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public CastCategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CastCategoryModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public CastCategoryModel Save(CastCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<CastCategoryModel> SaveAsync(CastCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public CastCategoryModel Update(CastCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<CastCategoryModel> UpdateAsync(CastCategoryModel entity)
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
        // ~CastCategoryManager() {
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
