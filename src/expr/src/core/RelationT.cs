//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a correspondence between two elements
    /// </summary>
    public readonly struct Relation<T> : IRelation<T>
    {
        public readonly Key<uint> Key;

        public readonly RelationKind Kind;

        public readonly T Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public Relation(uint key, RelationKind kind, T a, T b)
        {
            Key = key;
            Kind = kind;
            Source = a;
            Target = b;
        }

        T IRelation<T,T>.Source
            => Source;

        T IRelation<T,T>.Target
            => Target;

        Key<uint> IRelation.Key
            => Key;

        RelationKind IRelation.Kind
            => Kind;
    }
}