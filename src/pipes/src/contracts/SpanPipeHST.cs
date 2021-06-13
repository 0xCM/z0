//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class SpanPipe<H,S,T> : PipelinePart<H>, ISpanPipe<S,T>
        where H : SpanPipe<H,S,T>, new()
    {

        public void Invoke(ReadOnlySpan<S> src, Span<T> dst)
        {
            SignalStart();
            Project(src,dst);
            SignalEnd();
        }

        protected abstract uint Project(ReadOnlySpan<S> src, Span<T> dst);

        protected abstract void SignalStart();

        protected abstract void SignalEnd();
    }
}