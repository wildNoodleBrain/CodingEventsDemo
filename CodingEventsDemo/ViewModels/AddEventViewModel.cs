using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public EventDetails Type { get; set; }

        public List<SelectListItem> EventTypes { get; set;  } = new List<SelectListItem>
        {
            new SelectListItem(EventDetails.Conference.ToString(), ((int)EventDetails.Conference).ToString()),
            new SelectListItem(EventDetails.Meetup.ToString(), ((int)EventDetails.Meetup).ToString()),
            new SelectListItem(EventDetails.Social.ToString(), ((int)EventDetails.Social).ToString()),
            new SelectListItem(EventDetails.Workshop.ToString(), ((int)EventDetails.Workshop).ToString())
        };

    }
}
