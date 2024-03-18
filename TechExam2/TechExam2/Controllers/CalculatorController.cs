using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechExam2.Interface;
using TechExam2.Model;
using TechExam2.Service;

namespace TechExam2.Controllers
{
    [ApiController]
    [Route("api/")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _iCalculatorService;
        public CalculatorController(ICalculatorService iCalculatorService)
        {
            _iCalculatorService = iCalculatorService;
        }
        [HttpPost("RoundSumOfTwoNumber")]
        //public async IActionResult RoundSumOfTwoNumber(CalculateRequest request)
        public async Task<ActionResult> RoundSumOfTwoNumber(CalculateRequest request)
        {
            CalculateResponse calculateResponse = new CalculateResponse();
            //apply a task.run method here since we already had omitted it in the service and dump the results to the model.
            calculateResponse.Answer = await Task.Run(() => _iCalculatorService.RoundingSumOf2Int(request.FirstNumber, request.SecondNumber)).ConfigureAwait(false);

            return Ok(calculateResponse);
        }
    }
}
