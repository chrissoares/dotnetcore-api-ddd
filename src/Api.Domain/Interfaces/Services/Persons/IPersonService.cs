using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Persons
{
    public interface IPersonService
    {
        Task<PersonEntity> Get(Guid id);
        Task<IEnumerable<PersonEntity>> GetAll();
        Task<PersonEntity> Post(PersonEntity person);
        Task<PersonEntity> Put(PersonEntity person);
        Task<bool> Delete (Guid id);
    }
}
