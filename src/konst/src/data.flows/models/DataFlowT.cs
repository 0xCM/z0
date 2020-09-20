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

    public readonly struct DataFlow<T> : IDataFlow<T>
    {
        public readonly T Source;

        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<T> ((T src, T dst) x)
            => new DataFlow<T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator ArrowType<T,T> (DataFlow<T> x)
            => x.Type;

        [MethodImpl(Inline)]
        public DataFlow(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1}", Source, Target);

        public ArrowType<T,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        T IArrow<T,T>.Source
            => Source;

        T IArrow<T,T>.Target
            => Target;
    }
}