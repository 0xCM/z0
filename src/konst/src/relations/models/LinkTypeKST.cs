//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Graphs;

    public readonly struct LinkType<S,T,K>
        where K : unmanaged
    {
        public Type Kind {get;}

        public Type Source {get;}

        public Type Target {get;}

        [MethodImpl(Inline)]
        internal LinkType(Type kind, Type src, Type dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(LinkType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => Links.format(this);

        public override int GetHashCode()
            => (int)api.hash32(this);

        public static implicit operator Type(LinkType<S,T,K> src)
            => typeof(Link<S,T,K>);

        [MethodImpl(Inline)]
        public static implicit operator LinkType(LinkType<S,T,K> src)
            => new LinkType(src.Source, src.Target, src.Kind);
    }
}