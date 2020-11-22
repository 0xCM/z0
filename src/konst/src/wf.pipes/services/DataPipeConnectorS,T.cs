//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    using api = Pipes;

    public readonly struct DataPipeConnector<S,T> : IDataPipeConnector<S,T>
        where S : struct
        where T : struct
    {
        internal readonly DataPipe<S,T> Source;

        internal readonly DataPipe<T> Target;

        [MethodImpl(Inline)]
        internal DataPipeConnector(DataPipe<S,T> src, DataPipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<S> src)
            => api.flow(this, src);
    }
}