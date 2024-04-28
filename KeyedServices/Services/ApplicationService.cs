// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Models;
using KeyedServices.Models.Enums;
using KeyedServices.Services.Interfaces;

namespace KeyedServices.Services;

public class ApplicationService(
    EmailMessageService emailMessageService,
    PushMessageService pushMessageService,
    SmsMessageService smsMessageService)
    : IApplicationService
{
    public ProcessResult SendMessage(Message message) =>
        message.MessageType switch
        {
            NotificationType.Email => SendEmailMessage(message.MessageText),
            NotificationType.Push => SendPushMessage(message.MessageText),
            NotificationType.Sms => SendSmsMessage(message.MessageText),
            _ => new ProcessResult(
                isSuccess: false,
                message: "NotificationType not matched."),
        };

    public ProcessResult SendEmailMessage(string messageText)
    {
        return emailMessageService.SendMessage(messageText);
    }

    public ProcessResult SendPushMessage(string messageText)
    {
        return pushMessageService.SendMessage(messageText);
    }

    public ProcessResult SendSmsMessage(string messageText)
    {
        return smsMessageService.SendMessage(messageText);
    }
}
