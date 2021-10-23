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
    /// Defines a correspondence between two elements
    /// </summary>
    public struct Relation<S,T> : IRelation<S,T>
    {
        public readonly Key<uint> Key;

        public readonly RelationKind Kind;

        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public Relation(uint key, RelationKind kind, S src, T dst)
        {
            Key = key;
            Kind = kind;
            Source = src;
            Target = dst;
        }

        RelationKind IRelation.Kind
            => Kind;

        S IRelation<S,T>.Source
            => Source;

        T IRelation<S,T>.Target
            => Target;

        Key<uint> IRelation.Key
            => Key;
    }
}