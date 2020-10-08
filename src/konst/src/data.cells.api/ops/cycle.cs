//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;


    using static Konst;
    using static z;

    partial class Cells
    {
        [MethodImpl(Inline)]
        public static CellCycle<T> cycle<T>(T[] src)
            where T : unmanaged, IDataCell
                => new CellCycle<T>(src);

        [MethodImpl(Inline)]
        public static CellCycle<T> cycle<T>(ReadOnlySpan<T> src)
            where T : unmanaged, IDataCell
                => new CellCycle<T>(src);
    }
}