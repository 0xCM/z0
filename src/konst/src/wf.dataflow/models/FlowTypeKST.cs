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

    public readonly struct FlowType<K,S,T>
        where K : unmanaged
    {
        public readonly Type Kind;

        public readonly Type Source;

        public readonly Type Target;

        public static Type Type
            => typeof(Arrow<K,S,T>);

        public static implicit operator Type(FlowType<K,S,T> src)
            => typeof(Arrow<K,S,T>);

        [MethodImpl(Inline)]
        public static implicit operator FlowType(FlowType<K,S,T> src)
            => new FlowType(src.Kind, src.Source, src.Target);

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

        public override int GetHashCode()
            => (int)api.hash32(this);
    }
}