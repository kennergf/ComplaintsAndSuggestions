using System.Collections.Generic;
using ComplaintsAndSuggestions.Entities;

namespace ComplaintsAndSuggestions.Services
{
    public interface IComplaintSuggestionData
    {
        /// <summary>
        /// Return all Complaint and Suggestion register
        /// </summary>
        /// <returns></returns>
        IEnumerable<ComplaintSuggestion> GetAll();

        /// <summary>
        /// Add a new Complaint and/or Suggestion
        /// </summary>
        /// <param name="newComplaintSuggestion"></param>
        void Add(ComplaintSuggestion newComplaintSuggestion);

        /// <summary>
        /// Save changes
        /// </summary>
        /// <returns></returns>
        int Commit();
    }
}