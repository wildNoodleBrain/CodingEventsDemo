﻿using System.ComponentModel.DataAnnotations;




namespace CodingEventsDemo.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required(ErrorMessage = "Name of Event is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters")]
        public string Name { get; set; }
    }
}
