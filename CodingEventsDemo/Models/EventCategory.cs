using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace CodingEventsDemo.Models
{
    public class EventCategory : DbContext
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public string Categories { get; set; }

        public EventCategory(string name)
        {
            Name = name;
        }

        public EventCategory()
        {
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Database, ChangeTracker, Model, ContextId, Name, Id);
        }
    }
}