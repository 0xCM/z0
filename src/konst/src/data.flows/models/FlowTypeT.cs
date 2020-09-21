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

    /// <summary>
    /// Defines the type signature for a node-homogenous arrow
    /// </summary>
    public readonly struct FlowType<T>
    {
        public readonly Type Source;

        public readonly Type Target;

        public static Type Type
            => typeof(FlowType<T>);

        public static implicit operator Type(FlowType<T> src)
            => typeof(FlowType<T>);

        [MethodImpl(Inline)]
        public static implicit operator FlowType(FlowType<T> src)
            => new FlowType(src.Source, src.Target);

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
            get => (uint)typeof(FlowType<T>).GetHashCode();
        }

        public ulong Hash64
        {
            [MethodImpl(Inline)]
            get => hash(Source,Target);
        }

        public override int GetHashCode()
            => (int)Hashed;
    }
}