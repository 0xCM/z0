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

    public readonly struct FlowType : IEquatable<FlowType>
    {
        public Type Source {get;}

        public Type Target {get;}

        public Type Kind {get;}

        [MethodImpl(Inline)]
        internal FlowType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
            Kind = typeof(void);
        }

        [MethodImpl(Inline)]
        internal FlowType(Type kind, Type src, Type dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(FlowType src)
            => api.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)api.hash32(this);

        public override bool Equals(object src)
            => src is FlowType x && Equals(x);

        [MethodImpl(Inline)]
        public static bool operator ==(FlowType a, FlowType b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(FlowType a, FlowType b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator FlowType((Type src, Type dst) x)
            => new FlowType(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator FlowType((Type src, Type dst, Type kind) x)
            => new FlowType(x.src, x.dst, x.kind);
    }
}