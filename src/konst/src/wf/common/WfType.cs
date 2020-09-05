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

    public readonly struct WfType : IEquatable<WfType>
    {
        public readonly Type Source;

        public readonly Type Target;

        [MethodImpl(Inline)]
        public static bool operator ==(WfType a, WfType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(WfType a, WfType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator WfType((Type src, Type dst) x)
            => new WfType(x.src, x.dst);

        [MethodImpl(Inline)]
        internal WfType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(WfType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash32(this);

        public override bool Equals(object src)
            => src is WfType x && Equals(x);
    }
}