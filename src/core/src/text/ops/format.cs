//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static unsafe string format(StringAddress src)
            => new string(gptr(firstchar(src)));

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<AsciCode> src, Span<char> buffer)
        {
            var i=0u;
            var count = render(src, ref i, buffer);
            var chars = core.slice(buffer,0,count);
            return new string(chars);
        }

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> src, Span<char> buffer)
        {
            var i=0u;
            var count = render(src, ref i, buffer);
            var chars = core.slice(buffer,0,count);
            return new string(chars);
        }

        [MethodImpl(Inline), Op]
        public static string format(in AsciLine src, Span<char> buffer)
            => format(src.Content, buffer);

        [MethodImpl(Inline), Op]
        public static string format(in Utf16Line src, Span<char> buffer)
            => format(src.Content, buffer);
    }
}