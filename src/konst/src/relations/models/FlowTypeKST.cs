//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = DataFlows;

    public readonly struct LinkType<K,S,T>
        where K : unmanaged
    {
        public Type Kind {get;}

        public Type Source {get;}

        public Type Target {get;}

        public static Type Type
            => typeof(Link<K,S,T>);

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
            => api.format(this);

        public override int GetHashCode()
            => (int)api.hash32(this);

        public static implicit operator Type(LinkType<K,S,T> src)
            => typeof(Link<K,S,T>);

        [MethodImpl(Inline)]
        public static implicit operator LinkType(LinkType<K,S,T> src)
            => new LinkType(src.Source, src.Target, src.Kind);
    }
}