using Microsoft.AspNetCore.Mvc;

namespace LoanApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLoanApplications()
        {
            return Ok("List of Loan Applications");
        }

        [HttpPost]
        public IActionResult ApplyForLoan([FromBody] LoanApplication loan)
        {
            // Logic to apply for loan
            return Ok("Loan application submitted");
        }
    }

    public class LoanApplication
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public int Duration { get; set; }
    }
}
