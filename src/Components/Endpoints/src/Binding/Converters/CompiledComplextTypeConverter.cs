// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Components.Endpoints.Binding;

internal class CompiledComplextTypeConverter<T>(CompiledComplextTypeConverter<T>.ConverterDelegate body) : FormDataConverter<T>
{
    public delegate bool ConverterDelegate(ref FormDataReader reader, Type type, FormDataSerializerOptions options, out T? result, out bool found);

    internal override bool TryRead(ref FormDataReader context, Type type, FormDataSerializerOptions options, out T? result, out bool found)
    {
        return body(ref context, type, options, out result, out found);
    }
}
