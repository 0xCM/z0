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

    public readonly struct ArrowType : IEquatable<ArrowType>
    {
        public readonly Type Kind;

        public readonly Type Source;

        public readonly Type Target;

        [MethodImpl(Inline)]
        public static bool operator ==(ArrowType a, ArrowType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(ArrowType a, ArrowType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType((Type src, Type dst) x)
            => new ArrowType(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType((Type kind, Type src, Type dst) x)
            => new ArrowType(x.kind, x.src, x.dst);

        [MethodImpl(Inline)]
        internal ArrowType(Type src, Type dst)
        {
            Kind = typeof(void);
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        internal ArrowType(Type kind, Type src, Type dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(ArrowType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash32(this);

        public override bool Equals(object src)
            => src is ArrowType x && Equals(x);
    }
}