//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Pipes
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Conduit<T> connect<T>(Pipe<T> src, Pipe<T> dst)
            => new Conduit<T>(src,dst);

        [MethodImpl(Inline)]
        public static Conduit<S,T> connect<S,T>(Pipe<S,T> src, Pipe<T> dst)
            => new Conduit<S,T>(src,dst);
    }
}
