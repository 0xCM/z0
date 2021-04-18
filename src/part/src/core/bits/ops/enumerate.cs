//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    partial struct bit
    {
        [Op, Closures(Closure)]
        public static IEnumerable<bit> enumerate<T>(T src)
            where T : struct
        {
            var size = size<T>();
            var buffer = sys.alloc<bit>(size*8);
            bit.fill(src, buffer);
            foreach(var bit in buffer)
                yield return bit;
        }
    }
}