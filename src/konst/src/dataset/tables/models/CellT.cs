//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell<T>
        where T : unmanaged
    {
        public readonly T Data;

        [MethodImpl(Inline)]
        public Cell(T data)            
            => Data = data;
    }
}