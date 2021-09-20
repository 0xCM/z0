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

    using static Root;
    using static core;

    public sealed class QueueCache<T>
    {
        public static QueueCache<T> create()
            => new QueueCache<T>();

        readonly ConcurrentQueue<T> Queue;

        public QueueCache()
        {
            Queue = new ConcurrentQueue<T>();
        }

        public uint Count
            => (uint)Queue.Count;

        [MethodImpl(Inline)]
        public bool Take(out T item)
            => Queue.TryDequeue(out item);

        public uint Take(Span<T> dst)
        {
            var max = (uint)dst.Length;
            var taken = 0u;
            for(var i=0; i<max; i++)
            {
                if(Take(out var item))
                {
                    seek(dst,i) = item;
                    taken++;
                }
                else
                    break;
            }
            return taken;
        }

        public IEnumerable<T> Take()
        {
            while(Take(out var e))
                yield return e;
        }

        public void Deposit(in T src)
            => Queue.Enqueue(src);
    }
}