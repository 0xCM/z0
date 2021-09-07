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
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static GridSpec grid<T>(uint rows, uint cols)
                where T : unmanaged
                    => CellCalcs.gridspec((ushort)rows, (ushort)cols, (ushort)width<T>());
        }
    }
}