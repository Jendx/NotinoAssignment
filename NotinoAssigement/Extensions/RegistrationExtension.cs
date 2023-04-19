﻿namespace NotinoAssigement.Extensions;
using Notino.Domain.Models;
using NotinoAssigement.Handlers;
using NotinoAssigement.Handlers.Abstraction;

internal static class RegistrationExtension
{
    public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();

        builder.RegisterHandlers();

        return builder;
    }

    private static WebApplicationBuilder RegisterHandlers(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddSingleton<IHandler<Document>, CreateDocumentHandler>();

        return builder;
    }
}
