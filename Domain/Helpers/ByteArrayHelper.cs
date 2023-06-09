﻿namespace Notino.Domain.Helpers;

using System.Text.Json;

public static class ByteArrayHelper
{
    public static byte[] ToByteArray<TData>(this TData data)
    {
        return JsonSerializer.SerializeToUtf8Bytes(data, new JsonSerializerOptions { WriteIndented = true });
    }

    public static TData FromByteArray<TData>(this byte[] data)
    {
        return JsonSerializer.Deserialize<TData>(data);
    }
}
