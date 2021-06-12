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

    partial struct SymbolicTools
    {
        [MethodImpl(Inline), Op]
        public static uint copy(string src, ref uint i, Span<char> dst)
        {
            var input = src.ToSpan();
            var count = input.Length;
            var counter = 0u;
            for(var j=0; j<count; j++, counter++)
                seek(dst, i++) = skip(input,j);
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint copy(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var count = src.Length;
            var counter = 0u;
            for(var j=0; j<count; j++, counter++)
                seek(dst, i++) = skip(src, j);
            return counter;
        }
    }
}