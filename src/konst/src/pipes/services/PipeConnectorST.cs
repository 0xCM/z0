//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PipeConnector<S,T> : IPipeConnector<S,T>
    {
        internal readonly Pipe<S,T> Source;

        internal readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        public PipeConnector(Pipe<S,T> src, Pipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<S> src)
            => Pipes.flow(this, src);
    }
}