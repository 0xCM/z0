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

    partial struct StringTables
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(StringTable src, int i)
        {
            var offsets = src.Offsets;
            var i0 = bw32(skip(offsets, i));
            var count = src.EntryCount;
            var data = src.Data;
            if(i < count - 1)
            {
                var i1 = bw32(skip(offsets, i + 1));
                var length = i1 - i0;
                return slice(data, i0, length);
            }
            else
                return slice(data,i0);
        }
    }
}