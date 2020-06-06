//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic    
    {        
        [Op]
        public static string format(ReadOnlySpan<BinaryDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return new string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<DecimalDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length]; 
            render(src,dst);
            return new string(dst);
        }

        [Op]
        public static string format(ReadOnlySpan<HexDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return new string(dst);
        }

        [Op]
        public static string format(Base16 @base, UpperCased @case, ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[src.Length*3];
            render(@base, @case, src,digits);
            return digits.ToString();
        }       
    }
}