using System.Diagnostics;
using CedarAPI;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/evaluate", async ([FromBody] EvaluateRequest request) =>
{
    var psi = new ProcessStartInfo
    {
        FileName = "cedar",
        RedirectStandardOutput = true,
        UseShellExecute = false,
    };

    psi.ArgumentList.AddArgument("authorize", null);
    psi.ArgumentList.AddArgument("--policies", "configs/policy.cedar");
    psi.ArgumentList.AddArgument("--policy-format", "cedar");
    psi.ArgumentList.AddArgument("--entities", "configs/entities.json");
    psi.ArgumentList.AddArgument("--principal", $"User::\"{request.principal}\"");
    psi.ArgumentList.AddArgument("--action", $"Action::\"{request.action}\"");
    psi.ArgumentList.AddArgument("--resource", $"Document::\"{request.resource}\"");

    Process process = null!;
    try
    {
        process = Process.Start(psi)!;
    }
    catch (System.ComponentModel.Win32Exception ex) when (ex.Message.Contains("error occurred trying to start process 'cedar'"))
    {
        throw new Exception("Could not find cedar process. First, read the Readme.md file and follow the instructions.");
    }
    
    if (process == null)
        throw new Exception("First, read the Readme.md file and follow the instructions.");

    var output = await process.StandardOutput.ReadToEndAsync();
    await process.WaitForExitAsync();

    if (process.ExitCode != 0)
        return Results.BadRequest(new { output });

    return Results.Content(output, "application/json");

});

app.Run();

public record EvaluateRequest(string principal, string action, string resource);
