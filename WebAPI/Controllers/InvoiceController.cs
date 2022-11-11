using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        IInvoiceService _ınvoiceService;

        public InvoiceController(IInvoiceService ınvoiceService)
        {
            _ınvoiceService = ınvoiceService;
        }

        [HttpPost("add")]
        public IActionResult Add(InvoiceModelDto ınvoiceModelDto)
        {
            var result = _ınvoiceService.Add(ınvoiceModelDto);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
