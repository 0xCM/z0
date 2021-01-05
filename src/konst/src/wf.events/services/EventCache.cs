//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public sealed class EventCache : IWfEventCache
    {
        readonly ConcurrentQueue<IWfEvent> Queue;

        public EventCache()
        {
            Queue = new ConcurrentQueue<IWfEvent>();
        }

        public static IWfEventCache init(IWfShell wf)
            => new EventCache();

        public uint Count
            => (uint)Queue.Count;

        [MethodImpl(Inline)]
        public bool Take(out IWfEvent e)
            => Queue.TryDequeue(out e);

        public uint Take(Span<IWfEvent> dst)
        {
            var count = corefunc.min(Count, (uint)dst.Length);
            var taken = 0u;
            for(var i=0; i<count; i++)
            {
                if(Take(out var e))
                {
                    seek(dst,i) = e;
                    taken++;
                }
                else
                    break;
            }
            return taken;
        }

        public IEnumerable<IWfEvent> Take()
        {
            while(Take(out var e))
                yield return e;
        }

        public void Deposit(IWfEvent src)
        {
            Queue.Enqueue(src);
        }

        public void Dispose()
        {

        }
    }
}