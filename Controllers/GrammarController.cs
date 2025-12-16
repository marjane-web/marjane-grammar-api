using Microsoft.AspNetCore.Mvc;
using Marjane.Services;

namespace Marjane.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GrammarController : ControllerBase
{
    private readonly GrammarChecker _checker;

    public GrammarController()
    {
        _checker = new GrammarChecker();
    }

    // 👉 DIRETSONG TEXT INPUT (WALANG JSON OBJECT)
    [HttpPost("check")]
    [Consumes("application/json")]
    public IActionResult CheckGrammar([FromBody] string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return BadRequest("Walang text na ipinasa.");
        }

        var result = _checker.Check(text);
        return Ok(result);
    }
}
