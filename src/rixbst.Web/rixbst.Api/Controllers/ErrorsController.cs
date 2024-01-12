using Microsoft.AspNetCore.Mvc;

namespace rixbst.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/errors")]
    public IActionResult Error()
    {
        return Problem();
    }
}