// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Configuration;
using KeyedServices.Models;
using KeyedServices.Services.Interfaces;

namespace KeyedServices.Services;

public class MessageService(
    INotificationService notificationService)
    : IMessageService
{
    public ProcessResult SendMessage(string messageText)
    {
        return notificationService.SendNotification(messageText);
    }
}

public class EmailMessageService(
    [FromKeyedServices(Keys.Email)] INotificationService notificationService)
    : IMessageService
{
    public ProcessResult SendMessage(string messageText)
    {
        return notificationService.SendNotification(messageText);
    }
}

public class SmsMessageService(
    [FromKeyedServices(Keys.Sms)] INotificationService notificationService)
    : IMessageService
{
    public ProcessResult SendMessage(string messageText)
    {
        return notificationService.SendNotification(messageText);
    }
}

public class PushMessageService(
    [FromKeyedServices(Keys.Push)] INotificationService notificationService)
    : IMessageService
{
    public ProcessResult SendMessage(string messageText)
    {
        return notificationService.SendNotification(messageText);
    }
}
