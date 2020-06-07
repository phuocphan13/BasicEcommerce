using Ecommerce.Core.UoW;
using Ecommerce.Domain.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.UoW
{
    public class UnitOfWork : UnitOfWorkBase<EcommerceResourceContext>
    {
        public UnitOfWork(EcommerceResourceContext gmcContext, ILogger<UnitOfWork> logger) : base(gmcContext, logger)
        {
        }
    }
}
