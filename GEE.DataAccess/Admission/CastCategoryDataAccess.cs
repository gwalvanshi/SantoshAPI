using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
    public class CastCategoryDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();

        public List<CastCategory> GetAll()
        {
            return _context.CastCategories.ToList();
        }
    }
}
