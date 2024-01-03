using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class PersonEntity: BaseEntity
    {
        public string Name { get; set; }
        public DateTime? BornDay { get; set; }
    }
}
