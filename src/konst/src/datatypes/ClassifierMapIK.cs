//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClassifierMap<I,K> : IClassifierMapHost<ClassifierMap<I,K>,I,K>
        where I : unmanaged
        where K : unmanaged
    {
        internal readonly Paired<I,K>[] IndexKind;

        internal readonly Paired<K,I>[] KindIndex;

        public uint Count {get;}

        [MethodImpl(Inline)]
        internal ClassifierMap(uint count, Paired<I,K>[] index, Paired<K,I>[] kinds)
        {
            Count = count;
            IndexKind = index;
            KindIndex = kinds;
        }

        [MethodImpl(Inline)]
        public ref Paired<I,K> Index(uint i)
            => ref IndexKind[i];

        [MethodImpl(Inline)]
        public ref Paired<K,I> Kind(uint i)
            => ref KindIndex[i];
    }
}