﻿using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : GenericDal<Instructor>, IInstructorDal
    {
        public InstructorDal(List<Instructor> items) : base(items)
        {
        }
    }
}
