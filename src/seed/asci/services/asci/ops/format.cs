//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static string format(in asci2 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n2));
            decode(src,dst);
            return @string(dst);
        }       

        [MethodImpl(Inline), Op]
        public static string format(in asci4 src)
            => @string(asci.decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci5 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n5));
            decode(src,dst);
            return @string(dst.Slice(0, src.Length));
        }

        [MethodImpl(Inline), Op]
        public static string format(in asci8 src)
        {
            var dst = CharBlocks.c16s(CharBlocks.alloc(n8));
            decode(src,dst);            
            return @string(dst.Slice(0, src.Length));
        }        

        [MethodImpl(Inline), Op]
        public static string format(in asci16 src)
            => @string(decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci32 src)
            => @string(decode(src));

        [MethodImpl(Inline), Op]
        public static string format(in asci64 src)
            => @string(decode(src));

        [Op]
        public static string format(ReadOnlySpan<BinaryDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return @string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<DeciDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length]; 
            render(src,dst);
            return @string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<HexDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return @string(dst);
        }

        [Op]
        public static string format(Base16 @base, UpperCased @case, ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[src.Length*3];
            render(@base, @case, src,digits);
            return @string(digits);
        }                   
    }
}