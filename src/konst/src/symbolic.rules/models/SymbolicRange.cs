//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolicRange<T>
        where T : unmanaged
    {
        public T Min {get;}

        public T Max {get;}

        [MethodImpl(Inline)]
        public SymbolicRange(T min, T max)
        {
            Min = min;
            Max = max;
        }
    }
}