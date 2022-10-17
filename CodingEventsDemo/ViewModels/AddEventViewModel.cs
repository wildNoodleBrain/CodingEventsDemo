using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Location must be specified")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Number of tickets per person is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Number of tickets must be between 1 and 100")]
        public string Attendees { get; set; }
    }
}
