using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
   public class ClassesDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();
        public List<ClassMaster> GetAll()
        {
            return _context.ClassMasters.ToList();
        }
    }
}
