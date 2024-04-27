// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using KeyedServices.Models.Artifacts;

namespace KeyedServices.Models;

public readonly struct ProcessResult(
    bool isSuccess,
    string message = "")
    : IProcessResult
{
    public bool IsSuccess { get; } = isSuccess;

    public bool IsFailure => !IsSuccess;

    public string Message { get; } = $"{message}";
}
