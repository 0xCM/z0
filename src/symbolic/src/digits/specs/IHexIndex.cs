//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IHexIndex<T> : IReadOnlyIndex<T>
    {
        ref readonly T this[HexKind index] {get;}

        [MethodImpl(Inline)]
        ref readonly T Lookup(HexKind index)
            => ref this[index];
    }
}