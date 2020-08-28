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

    public readonly struct WfDataFlow<S,T> : IDataFlow<S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator WfDataFlow<S,T> ((S src, T dst) x)
            => new WfDataFlow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator WfType<S,T> (WfDataFlow<S,T> x)
            => x.Type;

        [MethodImpl(Inline)]
        public WfDataFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1}", Source, Target);

        public WfType<S,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        S IDataFlow<S,T>.Source
            => Source;

        T IDataFlow<S,T>.Target
            => Target;
    }
}