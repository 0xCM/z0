//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SymbolRange<T>
        where T : unmanaged
    {
        public T Min {get;}

        public T Max {get;}

        [MethodImpl(Inline)]
        public SymbolRange(T min, T max)
        {
            Min = min;
            Max = max;
        }
    }
}