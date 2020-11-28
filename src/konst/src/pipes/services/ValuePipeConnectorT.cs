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

    public readonly struct ValuePipeConnector<T> : IValuePipeConnector<T,T>
        where T : struct
    {
        internal readonly ValuePipe<T> Source;

        internal readonly ValuePipe<T> Target;

        [MethodImpl(Inline)]
        internal ValuePipeConnector(ValuePipe<T> src, ValuePipe<T> dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Flow(ReadOnlySpan<T> src)
            => api.flow(this, src);
    }
}