using Microsoft.AspNetCore.Mvc;

namespace rixbst.Api.Controllers;

[Route("[controller]")]
public class TransactionsController : ApiController
{
    [HttpGet]
    public IActionResult ListTransactions()
    {
        return Ok(Array.Empty<string>());
    }
}