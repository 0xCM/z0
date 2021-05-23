//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class EventFlow<S,T> : IDataFlow<S,T>
        where S : IInitialEvent<S>, new()
        where T : ITerminalEvent<T>, new()
    {
        public S Source {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public EventFlow(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator EventFlow<S,T>((S src, T dst) flow)
            => new EventFlow<S,T>(flow.src, flow.dst);
    }
}