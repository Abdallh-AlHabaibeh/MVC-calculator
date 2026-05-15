using Microsoft.AspNetCore.Mvc;
using Calculator.Models;
using Calculator.Services;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            model.Result = _calculatorService.Calculate(model.Expression);

            return View(model);
        }
        [HttpGet]
    public IActionResult Calculate(string expression)
    {
    try {
        var result = _calculatorService.Calculate(expression);
        string res = result.ToString();
        
        if (res == "Infinity" || res == "NaN") return BadRequest("Error");
        
        return Content(res);
    }
    catch {
        return BadRequest("Invalid");
    }
    }
    }
}