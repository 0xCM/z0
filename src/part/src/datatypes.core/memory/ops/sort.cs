//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct memory
    {
        [Op]
        public static Index<MemoryAddress> sort(ReadOnlySpan<MemoryAddress> src)
        {
            var dst = src.ToArray();
            Array.Sort(dst);
            return dst;
        }
    }
}