//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct GridCalcs
    {
        [MethodImpl(Inline), Op]
        public static uint points(in GridMetrics src)
            => (uint)(src.RowCount*src.ColCount);
    }
}