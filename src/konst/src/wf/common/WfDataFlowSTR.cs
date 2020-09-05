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

    public readonly struct WfDataFlow<S,T,R> : IDataFlow<S,T,R>
    {
        public readonly S Source;

        public readonly T Target;

        public readonly R Result;

        [MethodImpl(Inline)]
        public static implicit operator WfDataFlow<S,T,R>((S src, T dst, R result) x)
            => new WfDataFlow<S,T,R>(x.src, x.dst, x.result);

        [MethodImpl(Inline)]
        public static implicit operator WfType<S,T>(WfDataFlow<S,T,R> x)
            => x.Type;

        [MethodImpl(Inline)]
        public WfDataFlow(S src, T dst, R result)
        {
            Source = src;
            Target = dst;
            Result = result;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1} | {2}", Source, Target, Result);

        public WfType<S,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        S IDataFlow<S,T>.Source
            => Source;

        T IDataFlow<S,T>.Target
            => Target;
        R IDataFlow<S,T,R>.Result
            => Result;
    }
}