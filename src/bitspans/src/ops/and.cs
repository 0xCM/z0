//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
        {
            var count = z.BitCount;
            for(var i=0u; i<count; i++)
                z[i] = x[i] & y[i];
            return ref z;
        }

        [Op]
        public static BitSpan and(in BitSpan x, in BitSpan y)
            => and(x,y, alloc(y.BitCount));
    }
}