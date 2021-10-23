//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines an undirected association between a source and a target
    /// </summary>
    public readonly struct Relation<K,S,T> : IRelation<K,S,T>
    {
        public readonly Key<uint> Key;

        public readonly K Kind;

        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public Relation(uint key, K kind, in S src, in T dst)
        {
            Key = key;
            Kind = kind;
            Source = src;
            Target = dst;
        }

        K IRelation<K,S,T>.Kind
            => Kind;

        S IRelation<S,T>.Source
            => Source;

        T IRelation<S,T>.Target
            => Target;

        Key<uint> IRelation.Key
            => Key;
    }
}