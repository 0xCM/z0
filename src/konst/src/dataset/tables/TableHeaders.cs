//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableHeaders
    {
        [MethodImpl(Inline), Op]
        public static HeaderCell header(uint index, string label, uint width)
            => new HeaderCell(index,label, width);

        [MethodImpl(Inline), Op]
        public static TableHeader header(HeaderCell[] data)
            => data;
    }
}