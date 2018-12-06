using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
    public class EnquiryTypeDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();

        public List<EnquiryType> GetAll()
        {
            return _context.EnquiryTypes.ToList();
        }
    }
}
