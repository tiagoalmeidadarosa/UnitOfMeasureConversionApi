using Microsoft.AspNetCore.Mvc;

namespace UnitOfMeasureConversionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly ILogger<ConversionController> _logger;

        public ConversionController(ILogger<ConversionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("pxtorem", Name = "GetPxToRem")]
        [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
        public double GetPxToRem(double number)
        {
            return number / 16;
        }

        [HttpGet("remtopix", Name = "GetRemToPx")]
        [ProducesResponseType(typeof(double), StatusCodes.Status200OK)]
        public double GetRemToPx(double number)
        {
            return number * 16;
        }
    }
}