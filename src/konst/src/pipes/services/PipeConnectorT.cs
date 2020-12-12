//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Pipes;

    public readonly struct PipeConnector<T> : IPipeConnector<T,T>
    {
        internal readonly Pipe<T> Source;

        internal readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        internal PipeConnector(Pipe<T> src, Pipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<T> src)
            => api.flow(this, src);
    }
}