//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text.Json;

    using static z;
    using static Konst;

    [ApiHost]
    public readonly struct JsonData
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonDataPacket<T> packet<T>(T src)
            => src;

        [Op, Closures(Closure)]
        public static JsonText serialize<T>(T src, bool indented = true)
            => JsonSerializer.Serialize(src, new JsonSerializerOptions{WriteIndented = indented});

        [Op, Closures(Closure)]
        public static JsonText serialize<T>(T src, FS.FilePath dst, bool indented = true)
        {
            var data = serialize(src, indented);
            using var writer = dst.Writer();
            writer.Write(data);
            return data;
        }

        [Op, Closures(Closure)]
        public static T materialize<T>(JsonText src)
        {
            var packet = JsonSerializer.Deserialize<JsonDataPacket<T>>(src);
            return packet.Content;
        }

        [Op, Closures(Closure)]
        public static T materialize<T>(FS.FilePath src)
        {
            using var reader = src.Reader();
            var data = reader.ReadToEnd();
            return materialize<T>(data);
        }

        [MethodImpl(Inline), Op]
        public static JsonText json(string src)
            => new JsonText(src);

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static Json<T> json<T>(T[] src)
            => new Json<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonText text<T>(in Json<T> src)
            => json(format(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(in Json<T> src)
            => src.Content?.ToString() ?? EmptyString;
    }
}