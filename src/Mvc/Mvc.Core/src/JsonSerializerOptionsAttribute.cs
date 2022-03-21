// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json;

namespace Microsoft.AspNetCore.Mvc;

[AttributeUsage(AttributeTargets.Class)]
public abstract class JsonSerializerOptionsAttribute : Attribute
{
    public abstract JsonSerializerOptions JsonSerializerOptions { get; }
}
