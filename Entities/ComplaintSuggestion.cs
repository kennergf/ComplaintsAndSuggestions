using System.ComponentModel.DataAnnotations;

namespace ComplaintsAndSuggestions.Entities
{
    public class ComplaintSuggestion
    {
        public int Id {get;set;}

        [Display(Name="Name")]
        public string Name {get;set;}

        public string Email {get;set;}
        
        public string Subject {get;set;}

        public string Description {get;set;}
    }
}