//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct FlowType<S,T>
    {
        public Type Source {get;}

        public Type Target {get;}

        public static Type Type
            => typeof(FlowType<S,T>);

        [MethodImpl(Inline)]
        internal FlowType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(FlowType src)
            => DataFlows.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => DataFlows.format(this);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(FlowType<S,T>).GetHashCode();
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => hash(Source,Target);
        }

        public override int GetHashCode()
            => (int)Hashed;

        public static implicit operator Type(FlowType<S,T> src)
            => typeof(FlowType<S,T>);

        [MethodImpl(Inline)]
        public static implicit operator FlowType(FlowType<S,T> src)
            => new FlowType(src.Source, src.Target);
    }
}