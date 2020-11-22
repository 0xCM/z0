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

    public readonly struct DataPipeConnector<T> : IDataPipeConnector<T,T>
        where T : struct
    {
        internal readonly DataPipe<T> Source;

        internal readonly DataPipe<T> Target;

        [MethodImpl(Inline)]
        internal DataPipeConnector(DataPipe<T> src, DataPipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<T> src)
            => api.flow(this, src);
    }
}