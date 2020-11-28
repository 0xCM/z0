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

    public readonly struct ValuePipeConnector<S,T> : IValuePipeConnector<S,T>
        where S : struct
        where T : struct
    {
        internal readonly ValuePipe<S,T> Source;

        internal readonly ValuePipe<T> Target;

        [MethodImpl(Inline)]
        internal ValuePipeConnector(ValuePipe<S,T> src, ValuePipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<S> src)
            => api.flow(this, src);
    }
}