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

    public readonly struct DataFlow<S,T,R> : IDataFlow<S,T,R>
    {
        public readonly S Source;

        public readonly T Target;

        public readonly Outcome<R> Outcome;

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T,R>((S src, T dst, R result) x)
            => new DataFlow<S,T,R>(x.src, x.dst, x.result);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType<S,T>(DataFlow<S,T,R> x)
            => x.Type;

        [MethodImpl(Inline)]
        public DataFlow(S src, T dst, R result)
        {
            Source = src;
            Target = dst;
            Outcome = result;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1} | {2}", Source, Target, Outcome);

        public ArrowType<S,T> Type
        {
            [MethodImpl(Inline)]
            get => DataFlows.type(Source,Target);
        }

        S IArrow<S,T>.Source
            => Source;

        T IArrow<S,T>.Target
            => Target;
        R IDataFlow<S,T,R>.Result
            => Outcome;
    }
}