//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Relations;

    public readonly struct DataFlow<K,S,T> : IDataFlow<S,T>
        where K : unmanaged
    {
        public readonly Actor<K> Actor;

        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public DataFlow(Actor<K> actor, S src, T dst)
        {
            Actor = actor;
            Source = src;
            Target = dst;
        }

        public string Format()
            => api.format(this);

        public string IdentityText
            => api.specifier(this);

        S IArrow<S,T>.Source
            => Source;

        T IArrow<S,T>.Target
            => Target;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<K,S,T>((K actor, S src, T dst) x)
            => new DataFlow<K,S,T>(x.actor, x.src, x.dst);
    }
}