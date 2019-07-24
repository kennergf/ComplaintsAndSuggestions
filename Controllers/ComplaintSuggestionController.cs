using ComplaintsAndSuggestions.Entities;
using ComplaintsAndSuggestions.Services;
using ComplaintsAndSuggestions.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintsAndSuggestions.Controllers
{
    public class ComplaintSuggestionController : Controller
    {
        private IComplaintSuggestionData _complaintsSuggestions;

        public ComplaintSuggestionController(IComplaintSuggestionData complaintSuggestion)
        {
            _complaintsSuggestions = complaintSuggestion;
        }

        public ViewResult Index()
        {
            var model = _complaintsSuggestions.GetAll().Select(complaintSuggestion =>
            new ComplaintSuggestionViewModel
            {
                Id = complaintSuggestion.Id,
                Subject = complaintSuggestion.Subject,
                Resume = complaintSuggestion.Description
                /* Resume = string.IsNullOrEmpty(complaintSuggestion.Description) ?
                    string.Empty : string.Join("", complaintSuggestion.Description.Take(100)) */
            });

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ComplaintSuggestion complaintSuggestion)
        {
            if(ModelState.IsValid)
            {
                _complaintsSuggestions.Add(complaintSuggestion);
                _complaintsSuggestions.Commit();

                return RedirectToAction("Index", "ComplaintSuggestionController");
            }
            else
            {
                return View();
            }
        }
    }
}