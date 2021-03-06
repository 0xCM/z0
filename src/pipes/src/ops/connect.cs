//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Pipes
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Channel<T> connect<T>(Pipe<T> src, Pipe<T> dst)
            => new Channel<T>(src,dst);

        [MethodImpl(Inline)]
        public static Channel<S,T> connect<S,T>(Pipe<S,T> src, Pipe<T> dst)
            => new Channel<S,T>(src,dst);
    }
}
