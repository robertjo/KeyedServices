// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Models;
using KeyedServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServices.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApplicationController(
    IApplicationService applicationService)
    : ControllerBase
{
    [HttpPost("SendMessage")]
    public IActionResult SendMessage(Message message)
    {
        var result = applicationService.SendMessage(message);

        return result.IsSuccess
            ? Ok(result.Message)
            : BadRequest(result.Message);
    }
}
