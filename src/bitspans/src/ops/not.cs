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
        public static ref readonly BitSpan not(in BitSpan x, in BitSpan z)
        {
            var count = z.Length;
            for(var i=0; i< count; i++)
                z[i] = ~ x[i];
            return ref z;
        }

        [Op]
        public static BitSpan not(in BitSpan x)
            => not(x, alloc(x.BitCount));
    }
}