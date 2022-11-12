using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CodingEventsDemo.Models
{
    public class EventCategory
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public EventCategory(string name)
        {
            Name = name;
        }
        public EventCategory()
        {
            
        }
    }
}
//@using CodingEventsDemo.Models;
//using Microsoft.EntityFrameworkCore;

//namespace CodingEventsDemo.Data
//{
  //  public class EventDbContext : DbContext
    //{
      //  public DbSet<Event> Events { get; set; }

        //public EventDbContext(DbContextOptions<EventDbContext> options)
          //    : base(options)
        //{
        //}
   // }
//}