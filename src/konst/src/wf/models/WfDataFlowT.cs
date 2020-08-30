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

    public readonly struct WfDataFlow<T> : IDataFlow<T>
    {
        public readonly T Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator WfDataFlow<T> ((T src, T dst) x)
            => new WfDataFlow<T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator WfType<T,T> (WfDataFlow<T> x)
            => x.Type;

        [MethodImpl(Inline)]
        public WfDataFlow(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1}", Source, Target);

        public WfType<T,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        T IDataFlow<T,T>.Source
            => Source;

        T IDataFlow<T,T>.Target
            => Target;
    }
}