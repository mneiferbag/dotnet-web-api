/*
 * Copyright (c) 2022 Markus Neifer
 * Licensed under the MIT License.
 * See file LICENSE in project root directory.
 */

// See https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio-code

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
