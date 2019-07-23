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
                Subject = complaintSuggestion.Subject
            });

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Entities.ComplaintSuggestion complaintSuggestion)
        {
            if(ModelState.IsValid)
            {
                _complaintsSuggestions.Add(complaintSuggestion);
                _complaintsSuggestions.Commit();

                return View();
            }
            else
            {
                return View();
            }
        }
    }
}