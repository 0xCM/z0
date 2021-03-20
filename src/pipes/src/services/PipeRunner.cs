//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    readonly struct PipeRunner : IPipeRunner
    {
        public uint Flow<T>(ReadOnlySpan<T> src, Pipe<T> dst)
            => Pipes.flow(src,dst);

        public uint Flow<T>(Pipe<T> src, Pipe<T> dst)
            => Pipes.flow(src,dst);
    }
}