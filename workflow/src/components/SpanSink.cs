//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public readonly struct SpanSink<T> : ISpanSink<T>
    {
        readonly SpanReceiver<T> Receiver;
        
        [MethodImpl(Inline)]
        internal SpanSink(SpanReceiver<T> receiver)
            => Receiver = receiver;
        
        [MethodImpl(Inline)]
        public void Accept(Span<T> src)
            => Receiver(src);
    }
}