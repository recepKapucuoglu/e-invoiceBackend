using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Entities.DTOs;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInvoiceDal : EfEntityRepositoryBase<Invoice, InvoiceContext>, IInvoiceDal
    {
    

       
    }


}
