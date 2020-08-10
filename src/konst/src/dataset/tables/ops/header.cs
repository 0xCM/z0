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

    partial struct Table
    {
        [MethodImpl(Inline), Op]
        public static HeaderCell header(uint index, string label, RenderWidth width)
            => new HeaderCell(index,label, width);

        [MethodImpl(Inline), Op]
        public static TableHeader header(HeaderCell[] data)
            => data;

        [MethodImpl(Inline)]
        public static TableHeader<F> header<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new TableHeader<F>(literals<F>());
    }
}