// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json.Serialization;

namespace KeyedServices.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NotificationType
{
    Unknown = 0,
    Message = 1,
    Sms = 2,
    Push = 3,
    Email = 4,
}
