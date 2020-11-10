//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Links;

    public readonly struct Link<T> : ILink<T>
    {
        public T Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public Link(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => api.identifier(Source, Target);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Link<T>((T src, T dst) x)
            => new Link<T>(x.src,x.dst);

        [MethodImpl(Inline)]
        public static implicit operator Link<T>(Pair<T> x)
            => new Link<T>(x.Left,x.Right);

        [MethodImpl(Inline)]
        public static implicit operator (T src, T dst)(Link<T> a)
            => (a.Source, a.Target);
    }
}