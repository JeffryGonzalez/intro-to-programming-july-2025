
using Microsoft.AspNetCore.Mvc;

namespace References.Api.Links;

public class LinkController(NameFormatter formatter) : ControllerBase
{
    // some code here that will get called when a GET /links is sent to this server.

    [HttpGet("/links")]
    public async Task<ActionResult> GetAllLinksAsync(CancellationToken token)
    {
        return Ok(formatter.FormatName("Bob", "Smith"));
    }
}
