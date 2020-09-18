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
    using static z;

    public readonly struct ArrowType<S,T>
    {
        public readonly Type Source;

        public readonly Type Target;

        public static Type Type
            => typeof(ArrowType<S,T>);

        public static implicit operator Type(ArrowType<S,T> src)
            => typeof(ArrowType<S,T>);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType(ArrowType<S,T> src)
            => new ArrowType(src.Source, src.Target);

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

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(ArrowType<S,T>).GetHashCode();
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