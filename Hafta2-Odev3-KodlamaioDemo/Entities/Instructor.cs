using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Instructor: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Biography { get; set; }

        //Bire çok ilişki
        public ICollection<Course> Courses { get; set; }
    }
}
