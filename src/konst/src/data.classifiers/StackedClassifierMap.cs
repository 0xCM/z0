//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct StackedClassifierMap<I,K>
        where I : unmanaged
        where K : unmanaged
    {
        readonly Span<Paired<I,K>> IndexKind;

        readonly Span<Paired<K,I>> KindIndex;

        public uint Count {get;}

        [MethodImpl(Inline)]
        public StackedClassifierMap(ClassifierMap<I,K> src)
        {
            Count = src.Count;
            IndexKind = src.IndexKind;
            KindIndex = src.KindIndex;
        }

        [MethodImpl(Inline)]
        public static implicit operator StackedClassifierMap<I,K>(ClassifierMap<I,K> src)
            => new StackedClassifierMap<I,K>(src);

        [MethodImpl(Inline)]
        public ref Paired<I,K> Index(uint i)
            => ref seek(IndexKind,i);

        [MethodImpl(Inline)]
        public ref Paired<K,I> Kind(uint i)
            => ref seek(KindIndex,i);
    }
}