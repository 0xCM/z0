//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = AB;
    using static z;

    public readonly struct WfType<S,T>
    {
        public readonly Type Source;

        public readonly Type Target;

        public static Type Type
            => typeof(WfType<S,T>);

        public static implicit operator Type(WfType<S,T> src)
            => typeof(WfType<S,T>);

        [MethodImpl(Inline)]
        public static implicit operator WfType(WfType<S,T> src)
            => new WfType(src.Source, src.Target);

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

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => (uint)typeof(WfType<S,T>).GetHashCode();
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