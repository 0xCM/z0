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
        public T Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public DataFlow(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0} -> {1}", Source, Target);

        public LinkType<T,T> Type
        {
            [MethodImpl(Inline)]
            get => api.type(Source,Target);
        }

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<T>((T src, T dst) x)
            => new DataFlow<T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public static implicit operator LinkType<T,T>(DataFlow<T> x)
            => x.Type;
    }
}