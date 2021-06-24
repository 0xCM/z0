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

    partial struct AsciSymbols
    {
        [Op]
        public static string format(in AsciSequence seq)
            => format(seq.Storage.ToReadOnlySpan());

        [Op]
        public static string format(in ReadOnlySpan<byte> src)
        {
            var len = src.Length;
            var dst = span(alloc<char>(len));
            for(var i=0u; i<len; i++)
                seek(dst, i) = (char)skip(src,i);
            return TextTools.format(dst);
        }
    }
}