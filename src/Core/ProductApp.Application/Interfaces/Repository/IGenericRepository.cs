using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetAllAsync();

        Task<T> GetByIdAsync(int id);
    }
}
