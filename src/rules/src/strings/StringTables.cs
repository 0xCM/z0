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
    public readonly partial struct StringTables
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static StringTableRow row(in StringTable src, uint index)
            => new StringTableRow(src.Name, index, text.format(src[index]));

        [MethodImpl(Inline), Op]
        public static uint rows(in StringTable src, uint offset, Span<StringTableRow> dst)
        {
            var j=0u;
            for(var i=offset; i<src.EntryCount && j<dst.Length; i++)
                seek(dst,j++) = row(src,i);
            return j;
        }
    }
}