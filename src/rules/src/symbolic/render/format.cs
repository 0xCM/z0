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

    partial struct SymbolicRender
    {
        [MethodImpl(Inline), Op]
        public static string format(in AsciLine src, Span<char> buffer)
            => format(src.Content, buffer);

        [MethodImpl(Inline), Op]
        public static string format(in UnicodeLine src, Span<char> buffer)
            => format(src.Content, buffer);

        [Op]
        public static string format(ReadOnlySpan<AsciCode> src)
            => format(src,span<char>(src.Length));

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<AsciCode> src, Span<char> buffer)
        {
            var i=0u;
            var count = render(src, ref i, buffer);
            var chars = slice(buffer,0,count);
            return new string(chars);
        }

        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<char> src, Span<char> buffer)
        {
            var i=0u;
            var count = render(src, ref i, buffer);
            var chars = slice(buffer,0,count);
            return new string(chars);
        }

        [Op]
        public static string format(BitfieldSeg src, Span<char> buffer)
        {
            var offset = 0u;
            var count = render(src,ref offset, buffer);
            return new string(slice(buffer, 0u, count));
        }
    }
}