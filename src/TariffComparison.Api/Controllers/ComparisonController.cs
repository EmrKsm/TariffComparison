using Microsoft.AspNetCore.Mvc;
using TariffComparison.Application.Common.Interfaces;

namespace TariffComparison.Api.Controller;

[ApiController]
[Route("comparison")]
public class ComparisonController : ControllerBase
{
    private readonly IComparisonService _comparisonService;

    public ComparisonController(IComparisonService comparisonService)
    {
        _comparisonService = comparisonService;
    }

    [HttpGet("compare")]
    public IActionResult Compare(double consumption)
    {
        var list = _comparisonService.Compare(consumption);
        return Ok(list);
    }
}