using System.ComponentModel.DataAnnotations;

namespace ComplaintsAndSuggestions.Entities
{
    public class ComplaintSuggestion
    {
        public int Id {get;set;}

        [Required]
        public string Name {get;set;}

        [Required]
        public string Email {get;set;}
        
        [Required]
        public string Subject {get;set;}

        [Required]
        public string Description {get;set;}
    }
}