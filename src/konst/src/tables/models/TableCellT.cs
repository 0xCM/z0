//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableCell<T>
        where T : struct
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public TableCell(T data)            
            => Data = data;
    }
}