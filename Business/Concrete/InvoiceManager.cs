using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {

        IInvoiceDal _invoiceDal;

        public InvoiceManager(IInvoiceDal invoiceDal)
        {
            _invoiceDal = invoiceDal;
        }

        public IResult Add(InvoiceModelDto ınvoiceModelDto)
        {
            

                Invoice ınvoice = new Invoice();
                ınvoice.TotalPrice = ınvoiceModelDto.TotalPrice;
                ınvoice.Date = ınvoiceModelDto.Date;

                ınvoice.Products = ınvoiceModelDto.Products.
                    Select(i => new InvoiceProduct() 
                    {
                        Product = new Product
                        { 
                            Price = i.Price, ProductName=i.ProductName
                        }
                    }).ToList();
               
                _invoiceDal.Add(ınvoice);
            
            return new SuccessResult(Messages.Added);




        }

    }
}













