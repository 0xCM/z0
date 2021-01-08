//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Formatters
    {
        [MethodImpl(Inline), Op]
        public static HexDataFormatter data(MemoryAddress? @base = null, int bpl = 20, bool labels = true)
            => new HexDataFormatter(new HexLineConfig(bpl, labels), @base);

    }
}