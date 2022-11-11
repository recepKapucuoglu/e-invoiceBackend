using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class InvoiceModelDto:IDto
    {
        public int TotalPrice { get; set; }

        public DateTime Date { get; set; }

        public virtual List<Product> Products { get; set; }
    }

}
