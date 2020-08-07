//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Data;

    public readonly struct Table<F,T>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        public readonly T[] Data;

        [MethodImpl(Inline)]
        public Table(T[] data)
            => Data = data;
    }
}