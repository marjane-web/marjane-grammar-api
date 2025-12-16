using Microsoft.AspNetCore.Mvc;
using Marjane.Services;
using Marjane.Models;

namespace Marjane.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GrammarController : ControllerBase
{
    private readonly GrammarChecker _checker = new();

    [HttpPost("check")]
    public IActionResult CheckGrammar([FromBody] GrammarRequest request)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Text))
        {
            return BadRequest("Walang text na ipinasa.");
        }

        var result = _checker.Check(request.Text);
        return Ok(result);
    }
}
