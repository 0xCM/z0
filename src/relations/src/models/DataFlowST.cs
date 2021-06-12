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

    public readonly struct DataFlow<S,T> : IDataFlow<S,T>
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public DataFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public string IdentityText
        {
            [MethodImpl(Inline)]
            get => api.identifier(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T>((S src, T dst) x)
            => new DataFlow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T>(Paired<S,T> x)
            => new DataFlow<S,T>(x.Left, x.Right);
    }
}