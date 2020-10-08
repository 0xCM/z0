//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct DataCells<T>
        where T : unmanaged, IDataCell
    {
        readonly TableSpan<T> Data;

        [MethodImpl(Inline)]
        public DataCells(T[] src)
        {
            Data = src;
        }
    }
}