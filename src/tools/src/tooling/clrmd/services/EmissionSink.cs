//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;
    using System.Linq;

    public class EmissionSink : IEmissionSink<EmissionSink>
    {
        public static IEmissionSink create(Type host)
            => new EmissionSink(host);

        readonly ConcurrentDictionary<EventId,IWfEvent> Storage;

        object Locker;

        EventSignal Signal;

        EmissionSink(Type host, ConcurrentDictionary<EventId,IWfEvent> storage)
        {
            Storage = storage;
            Locker = new();
            Signal = EventSignal.create(this,host);
        }

        EmissionSink(Type host)
            : this(host, new())
        {
        }

        public void Deposit(IWfEvent src)
        {
            Storage.TryAdd(src.EventId,src);
        }


        public void Dispose()
        {
            if(Storage.Count != 0)
                term.warn("Sink disposed while events remain enqueued");
        }
    }
}