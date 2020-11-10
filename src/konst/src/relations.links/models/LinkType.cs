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

    public readonly struct LinkType : IEquatable<LinkType>
    {
        public Type Source {get;}

        public Type Target {get;}

        public Type Kind {get;}

        [MethodImpl(Inline)]
        internal LinkType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
            Kind = typeof(void);
        }

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

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash32(this);

        public override bool Equals(object src)
            => src is LinkType x && Equals(x);

        [MethodImpl(Inline)]
        public static bool operator ==(LinkType a, LinkType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(LinkType a, LinkType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator LinkType((Type src, Type dst) x)
            => new LinkType(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator LinkType((Type src, Type dst, Type kind) x)
            => new LinkType(x.src, x.dst, x.kind);
    }
}