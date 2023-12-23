using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate 
    {
        [Required(ErrorMessage ="E-mail is requried")]
        public string? Email { get; set; } = String.Empty;
        [Required(ErrorMessage ="FirstName is requried")]
        public string? FirstName { get; set; } = String.Empty;        
        [Required(ErrorMessage ="LastName is requried")]
        public string? LastName { get; set; } = String.Empty;
        
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int?  Age { get; set; }
        
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}