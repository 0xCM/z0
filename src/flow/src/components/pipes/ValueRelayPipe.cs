//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct ValueRelayPipe<T> : IValueRelayPipe<T>
        where T : struct
    {
        readonly RelayOp<T> f;
        
        [MethodImpl(Inline)]
        public ValueRelayPipe(RelayOp<T> f)
            => this.f = f;

        [MethodImpl(Inline)]
        public ref readonly T Relay(in T src)
            => ref f(in src);
    }
}