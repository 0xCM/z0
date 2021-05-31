//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    partial struct BitFields
    {
       public static BlockedBits<T> blocked<T>(uint bitcount)
            where T : unmanaged
                => new BlockedBits<T>(SpanBlocks.alloc<T>(n64, CellCalcs.bitcover<T>(bitcount)), bitcount);
    }
}