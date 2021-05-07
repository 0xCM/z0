//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    public class SpanProcessor<W,T> : AppService<W>
        where W : SpanProcessor<W,T>, new()
    {
        public void Submit(ReadOnlySpan<T> src)
        {
            var running = Wf.Running(string.Format("Processing {0} data", typeof(T).Name));
            var count = Process(src);
            Complete();
            Wf.Ran(running, string.Format("Processed {0} {1} items", count, typeof(T).Name));
        }

        protected virtual void Process(uint index, in T src)
        {

        }

        protected virtual void Complete()
        {

        }

        protected virtual uint Process(ReadOnlySpan<T> src)
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                Process(i, skip(src,i));
            return count;
        }
    }
}