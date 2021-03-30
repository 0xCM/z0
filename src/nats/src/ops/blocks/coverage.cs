//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct CellCalcs
    {
        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W128 w)
        {
            var r = src.StoreSize % 16;
            return r != 0 ? r + 1 : r;
        }

        [MethodImpl(Inline), Op]
        public static uint coverage(in GridMetrics src, W256 w)
        {
            var r = src.StoreSize % 32;
            return r != 0 ? r + 1 : r;
        }
    }
}