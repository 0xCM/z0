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
    using static Typed;

    partial struct Hex
    {
        [MethodImpl(Inline)]
        static uint render<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var size = src.Length;
            var j=0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = hexchar(@case, b, 0);
                seek(dst,j++) = hexchar(@case, b, 1);
            }
            return j;
        }

        [MethodImpl(Inline)]
        static char hexchar<C>(C @case, byte src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase, src, pos);
            else
                return hexchar(UpperCase, src, pos);
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]
        static uint render<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = (char)symbol(@case, skip(src,i));
            return count;
        }

        [Op]
        public static string format(ReadOnlySpan<byte> src, Span<char> buffer, bool lower = true)
            => lower ? format(LowerCase, src, buffer) : format(UpperCase, src, buffer);

        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src)
            where C : unmanaged, ILetterCase
        {
            Span<char> buffer = stackalloc char[src.Length];
            return format(@case, src, buffer);
        }

        public static string format<C>(C @case, ReadOnlySpan<byte> src)
            where C : unmanaged, ILetterCase
        {
            Span<char> buffer = stackalloc char[src.Length*3];
            return format(@case, src, buffer);
        }

        [MethodImpl(Inline)]
        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> buffer)
            where C : unmanaged, ILetterCase
        {
            var count = render(@case, src, buffer);
            return text.format(slice(buffer,0,count));
        }

        [MethodImpl(Inline)]
        public static string format<C>(C @case, ReadOnlySpan<byte> src, Span<char> buffer)
            where C : unmanaged, ILetterCase
        {
            var count = render(@case, src, buffer);
            return text.format(slice(buffer,0,count));
        }

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex2Seq> src,  Hex2Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex5Seq> src, Hex5Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex1Seq kind)
            => format(Hex.hexstring(n1), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex2Seq kind)
            => format(Hex.hexstring(n2), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex3Seq kind)
            => format(Hex.hexstring(n3), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex4Seq kind)
            => format(Hex.hexstring(n4), kind);
    }
}