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

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => api.identifier(this);
        }

        public string Format()
            => api.format(this);

        public LinkType Type
        {
            [MethodImpl(Inline)]
            get => api.type(this);
        }

        [MethodImpl(Inline)]
        public static implicit operator DataFlow<T>((T src, T dst) x)
            => new DataFlow<T>(x.src, x.dst);
    }
}