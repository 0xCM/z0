//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct ScalarParser
    {
        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out byte dst)
            => byte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out short dst)
            => short.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out int dst)
            => int.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out uint dst)
            => uint.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out long dst)
            => long.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out float dst)
            => float.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out double dst)
            => double.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(string src, out decimal dst)
            => decimal.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out byte dst)
            => byte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out short dst)
            => short.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out int dst)
            => int.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out uint dst)
            => uint.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out long dst)
            => long.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out float dst)
            => float.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool parse(ReadOnlySpan<char> src, out double dst)
            => double.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool int8(ReadOnlySpan<char> src, out sbyte dst)
            => sbyte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool uint8(ReadOnlySpan<char> src, out byte dst)
            => byte.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool int16(ReadOnlySpan<char> src, out short dst)
            => short.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool uint16(ReadOnlySpan<char> src, out ushort dst)
            => ushort.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool int32(ReadOnlySpan<char> src, out int dst)
            => int.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool uint32(ReadOnlySpan<char> src, out uint dst)
            => uint.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool int64(ReadOnlySpan<char> src, out long dst)
            => long.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool uint64(ReadOnlySpan<char> src, out ulong dst)
            => ulong.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool float32(ReadOnlySpan<char> src, out float dst)
            => float.TryParse(src, out dst);

        [Op, MethodImpl(Inline)]
        public static bool float64(ReadOnlySpan<char> src, out double dst)
            => double.TryParse(src, out dst);
    }
}