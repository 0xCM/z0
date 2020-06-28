//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IHexIndex<T> : IReadOnlyIndex<T>
    {
        ref readonly T this[HexKind8 index] {get;}

        [MethodImpl(Inline)]
        ref readonly T Lookup(HexKind8 index)
            => ref this[index];
    }
}