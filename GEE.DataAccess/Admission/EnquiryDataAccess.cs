using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.DataAccess.Admission
{
    public class EnquiryDataAccess
    {
        private readonly GEEDbContext _context = new GEEDbContext();

        public List<Enquiry> GetAll()
        {
            return _context.Enquiries.ToList();
        }
        public Enquiry GetById(int id)
        {
            return _context.Enquiries.Where(x => x.Enquiry_ID.Equals(id)).FirstOrDefault();
        }
        public Enquiry Save(Enquiry enquiry)
        {
            try
            {
                _context.Enquiries.Add(enquiry);               
                _context.SaveChanges();
                return enquiry;
            }
            catch
            {
                return null;
            }
        }

    }
}
