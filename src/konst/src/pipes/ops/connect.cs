//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Pipes
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PipeConnector<T> connect<T>(Pipe<T> src, Pipe<T> dst)
            => new PipeConnector<T>(src,dst);

        [MethodImpl(Inline)]
        public static PipeConnector<S,T> connect<S,T>(Pipe<S,T> src, Pipe<T> dst)
            => new PipeConnector<S,T>(src,dst);
    }
}
