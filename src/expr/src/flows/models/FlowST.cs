//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Flow<S,T> : INativeFlow<S,T>
        where S : INativeChannel
        where T : INativeChannel
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Flow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Format()
            => flows.format(this);


        public override string ToString()
            => Format();

        public string IdentityText
            => flows.syntax(this);

        [MethodImpl(Inline)]
        public static implicit operator Flow<S,T>((S src, T dst) x)
            => new Flow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Flow<S,T>(Paired<S,T> x)
            => new Flow<S,T>(x.Left, x.Right);
    }
}