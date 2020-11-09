//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Link<S,T> : ILink<Link<S,T>,S,T>
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Link(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => string.Concat(Source, Connector, Target);
        }

       [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        public override string ToString()
            => Format();

       [MethodImpl(Inline)]
        public static implicit operator Link<S,T>((S src, T dst) x)
            => new Link<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator (S src, T dst)(Link<S,T> a)
            => (a.Source, a.Target);
    }
}