using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : GenericDal<Course>, ICourseDal
    {
        public CourseDal(List<Course> items) : base(items)
        {
        }
    }
}
