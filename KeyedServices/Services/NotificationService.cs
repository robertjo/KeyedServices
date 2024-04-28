// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Models;
using KeyedServices.Services.Interfaces;

namespace KeyedServices.Services;

public class EmailNotificationService : INotificationService
{
    public ProcessResult SendNotification(string messageText)
    {
        return new ProcessResult(
            isSuccess: true,
            message: $"Message sent via Email: {messageText}");
    }
}

public class PushNotificationService : INotificationService
{
    public ProcessResult SendNotification(string messageText)
    {
        return new ProcessResult(
            isSuccess: true,
            message: $"Message sent via Push: {messageText}");
    }
}

public class SmsNotificationService : INotificationService
{
    public ProcessResult SendNotification(string messageText)
    {
        return new ProcessResult(
            isSuccess: true,
            message: $"Message sent via Sms: {messageText}");
    }
}
