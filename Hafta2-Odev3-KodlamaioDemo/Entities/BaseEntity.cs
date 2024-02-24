using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
