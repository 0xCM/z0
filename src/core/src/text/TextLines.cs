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

    using C = AsciCode;

    using static AsciCode;

    [ApiHost]
    public readonly struct TextLines
    {
        [MethodImpl(Inline), Op]
        public static bool eol(byte a0, byte a1)
            => (C)a0 == CR || (C)a1 == LF;

        [MethodImpl(Inline), Op]
        public static bool eol(char a0, char a1)
            => (C)a0 == CR || (C)a1 == LF;

        [MethodImpl(Inline), Op]
        public static LineRange range(uint min, uint max, TextLine[] data)
            => new LineRange(min, max, data);

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

        [MethodImpl(Inline), Op]
        public static AsciLine asci(ReadOnlySpan<byte> src, uint number, uint offset, uint chars)
            => new AsciLine(number, offset, recover<AsciCode>(slice(src, offset, chars)));

        [MethodImpl(Inline), Op]
        public static AsciLine asci(ReadOnlySpan<AsciCode> src, uint number, uint start, uint chars)
            => new AsciLine(number, start, slice(src, start, chars));

        [MethodImpl(Inline), Op]
        public static Utf16Line utf16(ReadOnlySpan<char> src, uint number, uint offset, uint chars)
            => new Utf16Line(number, offset, slice(src, offset, chars));

        public static Utf16Line utf16(ReadOnlySpan<byte> src, uint number, uint offset, uint chars)
            => new Utf16Line(number, 0, slice(recover<char>(src), offset, chars));

        [MethodImpl(Inline), Op]
        public static uint count(ReadOnlySpan<byte> src)
        {
            var size = src.Length;
            var counter = 0u;
            for(var pos=0u; pos<size- 1; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(eol(a0,a1))
                    counter++;
            }
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint count(ReadOnlySpan<char> src)
        {
            var size = src.Length;
            var counter = 0u;
            for(var pos=0u; pos<size- 1; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(eol(a0,a1))
                    counter++;
            }
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint maxlength(ReadOnlySpan<byte> src)
        {
            var size = src.Length;
            var max = 0u;
            var current = 0u;
            for(var pos=0u; pos<size; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(!eol(a0,a1))
                    current++;
                else
                {
                    if(current > max)
                        max = current;
                    current = 0;
                    pos++;
                }
            }
            return max;
        }

        [MethodImpl(Inline), Op]
        public static uint maxlength(ReadOnlySpan<char> src)
        {
            var size = src.Length;
            var max = 0u;
            var current = 0u;
            for(var pos=0u; pos<size; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(!eol(a0,a1))
                    current++;
                else
                {
                    if(current > max)
                        max = current;
                    current = 0;
                    pos++;
                }
            }
            return max;
        }
    }
}