using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Invoice : IEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public virtual List<InvoiceProduct> Products { get; set; }

        public Invoice()
        {
            Products = new List<InvoiceProduct>();
        }



    }
}
