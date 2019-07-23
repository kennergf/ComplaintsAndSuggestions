using System.Collections.Generic;
using ComplaintsAndSuggestions.Data;
using ComplaintsAndSuggestions.Entities;

namespace ComplaintsAndSuggestions.Services
{
    public class SqlComplaintSuggestionData : IComplaintSuggestionData
    {
        private ComplaintSuggestionDbContext _db;

        public SqlComplaintSuggestionData(ComplaintSuggestionDbContext db)
        {
            _db = db;
        }

        public IEnumerable<ComplaintSuggestion> GetAll()
        {
            return _db.ComplaintsSuggestions;
        }

        public void Add(ComplaintSuggestion newComplaintSuggestion)
        {
            _db.Add(newComplaintSuggestion);
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }
    }
}