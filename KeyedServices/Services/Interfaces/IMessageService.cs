// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Models;

namespace KeyedServices.Services.Interfaces;

public interface IMessageService
{
    public ProcessResult SendMessage(string messageText);
}
