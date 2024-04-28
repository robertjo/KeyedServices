// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using KeyedServices.Models.Enums;

namespace KeyedServices.Models;

public class Message
{
    public string MessageText { get; set; } = string.Empty;

    public NotificationType MessageType { get; set; }
}
