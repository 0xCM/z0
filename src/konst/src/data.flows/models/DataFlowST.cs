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

    public readonly struct DataFlow<S,T> : IDataFlow<S,T>
    {
        public readonly S Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T>((S src, T dst) x)
            => new DataFlow<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<S,T>(Paired<S,T> x)
            => new DataFlow<S,T>(x.Left, x.Right);

        [MethodImpl(Inline)]
        public static implicit operator FlowType<S,T>(DataFlow<S,T> x)
            => x.Type;

        [MethodImpl(Inline)]
        public DataFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1}", Source, Target);

        public FlowType<S,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        S IArrow<S,T>.Source
            => Source;

        T IArrow<S,T>.Target
            => Target;
    }
}