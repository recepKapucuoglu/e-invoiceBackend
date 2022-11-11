using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class InvoiceProduct : IEntity
    {
        public int? InvoiceId { get; set; }


        public int? ProductId { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
