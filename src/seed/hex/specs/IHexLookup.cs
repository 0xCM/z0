//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IHexLookup<T> : IConstIndex<T>
    {
        ref readonly T this[HexKind8 index] {get;}

        [MethodImpl(Inline)]
        ref readonly T Lookup(HexKind8 index)
            => ref this[index];
    }

    public interface IHexLookup<K,T> : IConstIndex<T>
        where K : unmanaged, Enum
    {
        ref readonly T this[K index] {get;}

        [MethodImpl(Inline)]
        ref readonly T Lookup(K index)
            => ref this[index];
    }    
}