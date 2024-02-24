using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course: BaseEntity
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CompletionRate { get; set; }

        //Foreign key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
