using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Core.UoW
{
    public interface IUnitOfWork
    {
        bool SaveChanges();

        Task<bool> SaveChangesAsync();
    }
}
