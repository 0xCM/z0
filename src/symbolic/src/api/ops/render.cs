//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static int render(ReadOnlySpan<HexDigitCodeUp> src, Span<char> dst)
        {
            var j = 0;
            for(int i = 0; i<src.Length; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return j;        
        }

        [MethodImpl(Inline), Op]
        public static int render(X16 @base, ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j = 0;
            for(int i = 0; i<src.Length; i++, j+=3)
            {
                ref readonly var code = ref skip(src, i);
                
                seek(dst, j) = hexchar(UpperCased.Case, code >> 4);
                seek(dst, j + 1) = hexchar(UpperCased.Case, 0xF & code);
                seek(dst, j + 2) = Chars.Space;
            }
            return j;
        }

        [Op]
        public static string render(X16 @base, ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[src.Length*3];
            render(@base, src,digits);
            return digits.ToString();
        }
    }
}