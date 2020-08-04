//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    using static EmittedHostBytesEvent;

    public readonly struct EmittedHostBytesEvent
    {
        public const string EventName = nameof(EmittedHostBytes);

        public const string Pattern = IdMarker + "{1} | {2} | {3}";
    }
    
    public readonly struct EmittedHostBytes : IWfEvent<EmittedHostBytes>
    {
        public WfEventId Id {get;}

        public string WorkerName {get;}
        
        public ApiHostUri Host {get;}

        public ushort AccessorCount {get;}

        [MethodImpl(Inline)]
        public EmittedHostBytes(string worker, ApiHostUri host, ushort count, CorrelationToken ct)
        {
            Id = wfid(nameof(EmittedHostBytes), ct);
            Host= host;
            WorkerName = worker;
            AccessorCount = count;
        }                
        
        public string Format()
            => text.format(Pattern, Id, WorkerName, Host.Format(), AccessorCount);        
    }
}