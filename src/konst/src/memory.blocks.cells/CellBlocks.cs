// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly partial struct CellBlocks
    {
        [MethodImpl(Inline), Op]
        public static CellBlock8 cover(byte[] src)
            => new CellBlock8(src);
    }
}