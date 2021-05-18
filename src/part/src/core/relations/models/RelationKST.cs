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
        public K Kind {get;}

        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Relation(K kind, in S src, in T dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Relation<K,S,T>((K kind, S src, T dst) x)
            => new Relation<K,S,T>(x.kind, x.src, x.dst);
    }
}