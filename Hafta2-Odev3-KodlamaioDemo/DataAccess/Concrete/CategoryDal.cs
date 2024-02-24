using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : GenericDal<Category>, ICategoryDal
    {
        public CategoryDal(List<Category> items) : base(items)
        {
        }
    }
}
