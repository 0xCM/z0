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
    public readonly struct ArrowType<T>
    {
        public readonly Type Source;

        public readonly Type Target;

        public static Type Type
            => typeof(ArrowType<T>);

        public static implicit operator Type(ArrowType<T> src)
            => typeof(ArrowType<T>);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType(ArrowType<T> src)
            => new ArrowType(src.Source, src.Target);

        [MethodImpl(Inline)]
        internal ArrowType(Type src, Type dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public bool Equals(ArrowType src)
            => DataFlows.eq(this, src);

        [MethodImpl(Inline)]
        public string Format()
            => DataFlows.format(this);

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(ArrowType<T>).GetHashCode();
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