
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
    public  class UnitDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();

        public List<tblUnit> GetAllUnit()
        {
            // var tblUnit = _context.tblUnits.Include(t => t.tblSizes).Include(t => t.tblUser).Include(t => t.tblUser1).Where(a => a.IsActive == true);
            var tblUnit = _context.tblUnits.Include(t => t.tblSizes);
            return tblUnit.ToList();
        }
    }
}
