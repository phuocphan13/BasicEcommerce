using Ecommerce.Core.Repositories;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Repositories
{
    public class Repository<TEntity> : RepositoryBase<TEntity, EcommerceResourceContext>
        where TEntity : class
    {
        public Repository(EcommerceResourceContext context) : base(context)
        {
        }
    }
}
