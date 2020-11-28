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
        [MethodImpl(Inline)]
        public static ValuePipeConnector<S,T> connect<S,T>(ValuePipe<S,T> src, ValuePipe<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new ValuePipeConnector<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static PipeConnector<S,T> connect<S,T>(Pipe<S,T> src, Pipe<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new PipeConnector<S,T>(src,dst);
    }
}
