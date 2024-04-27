// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KeyedServices.Models.Artifacts;

public interface IProcessResult
{
    bool IsFailure { get; }

    bool IsSuccess { get; }

    string Message { get; }
}
