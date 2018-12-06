using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
    public class AcademicYearDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();

        public List<AcademicYear> GetAll()
        {
            return _context.AcademicYears.ToList();
        }
    }
}
