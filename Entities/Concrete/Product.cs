using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }

        public virtual List<InvoiceProduct> Invoices { get; set; }

        public Product()
        {
            Invoices = new List<InvoiceProduct>();
        }
    }
}
