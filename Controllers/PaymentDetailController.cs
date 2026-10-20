using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PaymentDetails.models;
using PaymentDetails.Data;

[Route("api/[controller]")]
[ApiController]
public class PaymentDetailController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public PaymentDetailController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/PaymentDetailsModel
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PaymentDetailsModel>>> GetPaymentDetailsModel()
    {
        return await _context.paymentDetails.ToListAsync();
    }

    // GET: api/PaymentDetailsModel/5
    [HttpGet("{paymentid}")]
    public async Task<ActionResult<PaymentDetailsModel>> GetPaymentDetailsModel(int paymentid)
    {
        var paymentdetailsmodel = await _context.paymentDetails.FindAsync(paymentid);

        if (paymentdetailsmodel == null)
        {
            return NotFound();
        }

        return paymentdetailsmodel;
    }

    // PUT: api/PaymentDetailsModel/5
    [HttpPut("{paymentid}")]
    public async Task<IActionResult> PutPaymentDetailsModel(int? paymentid, PaymentDetailsModel paymentdetailsmodel)
    {
        if (paymentid != paymentdetailsmodel.paymentId)
        {
            return BadRequest();
        }

        _context.Entry(paymentdetailsmodel).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PaymentDetailsModelExists(paymentid))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<PaymentDetailsModel>> PostPaymentDetailsModel(PaymentDetailsModel paymentdetailsmodel)
    {
        _context.paymentDetails.Add(paymentdetailsmodel);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPaymentDetailsModel", new { paymentid = paymentdetailsmodel.paymentId }, paymentdetailsmodel);
    }

    // DELETE: api/PaymentDetailsModel/5
    [HttpDelete("{paymentid}")]
    public async Task<IActionResult> DeletePaymentDetailsModel(int? paymentid)
    {
        var paymentdetailsmodel = await _context.paymentDetails.FindAsync(paymentid);
        if (paymentdetailsmodel == null)
        {
            return NotFound();
        }

        _context.paymentDetails.Remove(paymentdetailsmodel);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PaymentDetailsModelExists(int? paymentid)
    {
        return _context.paymentDetails.Any(e => e.paymentId == paymentid);
    }
}
