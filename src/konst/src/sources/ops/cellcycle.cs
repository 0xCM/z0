//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline)]
        public static CellCycle<T> cellcycle<T>(Index<T> src)
            where T : unmanaged, IDataCell<T>
                => new CellCycle<T>(src);
    }
}