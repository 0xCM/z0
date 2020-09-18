//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Flow;

    public readonly struct ArrowType : IEquatable<ArrowType>
    {
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
        internal ArrowType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(ArrowType src)
            => Arrows.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => Arrows.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash32(this);

        public override bool Equals(object src)
            => src is ArrowType x && Equals(x);
    }
}