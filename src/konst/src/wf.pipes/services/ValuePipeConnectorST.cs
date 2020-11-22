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

    public readonly struct PipeConnector<S,T> : IPipeConnector<S,T>
    {
        readonly Pipe<S,T> Source;

        readonly Pipe<T> Target;

        [MethodImpl(Inline)]
        public PipeConnector(Pipe<S,T> src, Pipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<S> src)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Source.Deposit(skip(src,i));

            while(Source.Next(out var dst))
                Target.Deposit(dst);
        }
    }
}