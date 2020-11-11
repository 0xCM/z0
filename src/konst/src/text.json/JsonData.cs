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
        const NumericKind Closure = AllNumeric;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static JsonText serialize<T>(T src)
            => JsonSerializer.Serialize(src);

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