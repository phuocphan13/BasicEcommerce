using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core
{
    public class BaseEntityModel
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int UpdatedBy { get; set; }
    }
}
