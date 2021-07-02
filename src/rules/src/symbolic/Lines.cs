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

    [ApiHost]
    public readonly partial struct Lines
    {
        [MethodImpl(Inline), Op]
        public static TextLine line(uint number, string content)
            => new TextLine(number, content);

        [MethodImpl(Inline), Op]
        public static uint lines(ReadOnlySpan<string> src, Span<TextLine> dst)
        {
            var count = (uint)src.Length;
            var counter = 1u;
            for(var i=0; i<count; i++)
                seek(dst,i) = new TextLine(counter++, skip(src,i));
            return count;
        }

        [MethodImpl(Inline), Op]
        public static void convert(in AsciLine src, Span<char> buffer, out Utf16Line dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                seek(buffer, i) = (char)skip(src.Content,i);
            dst = new Utf16Line(src.LineNumber, src.StartPos, buffer);
        }
    }
}