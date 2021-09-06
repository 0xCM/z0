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

    partial struct Blit
    {
        partial struct Meta
        {
            /// <summary>
            /// Defines a block specification
            /// </summary>
            /// <param name="capacity"></param>
            /// <param name="cellwidth"></param>
            /// <param name="cellkind"></param>
            [MethodImpl(Inline), Op]
            public static DataBlock block(ByteSize capacity, BitWidth cellwidth, BlittableKind cellkind)
                => new DataBlock(capacity, cellwidth, cellkind);
        }
    }
}
