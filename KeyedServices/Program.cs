// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Configuration;
using KeyedServices.Services;
using KeyedServices.Services.Interfaces;

namespace KeyedServices;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IApplicationService, ApplicationService>();

        builder.Services.AddScoped<MessageService>();
        builder.Services.AddScoped<EmailMessageService>();
        builder.Services.AddScoped<PushMessageService>();
        builder.Services.AddScoped<SmsMessageService>();

        builder.Services.AddScoped<INotificationService, EmailNotificationService>();
        builder.Services.AddScoped<INotificationService, PushNotificationService>();
        builder.Services.AddScoped<INotificationService, SmsNotificationService>();

        builder.Services.AddKeyedScoped<INotificationService, EmailNotificationService>(Keys.Email);
        builder.Services.AddKeyedScoped<INotificationService, PushNotificationService>(Keys.Push);
        builder.Services.AddKeyedScoped<INotificationService, SmsNotificationService>(Keys.Sms);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
