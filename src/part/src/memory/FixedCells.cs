//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    [ApiHost]
    public readonly struct FixedCells
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static FixedCells<T> define<T>(MemoryAddress address, uint count)
            where T : struct
                => new FixedCells<T>(address,count);
    }
}