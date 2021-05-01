//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Hex
    {
        [Op]
        public static Outcome<uint> digits(ReadOnlySpan<char> src, Span<HexDigit> dst)
        {
            var j=0u;
            var count = root.min(src.Length, dst.Length);
            for(var i=0; i<src.Length; i++)
            {
                if(!Hex.parse((AsciChar)skip(src,i), out seek(dst,i)))
                    return false;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HexSymLo> src, Span<HexDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = digit(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void digits(ReadOnlySpan<HexSymUp> src, Span<HexDigit> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = digit(skip(src,i));
        }
    }
}