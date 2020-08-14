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
    using static RenderPatterns;

    [Event]
    public readonly struct EmittedHostBytes : IWfEvent<EmittedHostBytes>
    {
        public const string EventName = nameof(EmittedHostBytes);

        public WfEventId EventId {get;}

        public string ActorName {get;}
        
        public ApiHostUri Host {get;}

        public ushort AccessorCount {get;}

        [MethodImpl(Inline)]
        public EmittedHostBytes(string worker, ApiHostUri host, ushort count, CorrelationToken ct)
        {
            EventId = evid(nameof(EmittedHostBytes), ct);
            Host= host;
            ActorName = worker;
            AccessorCount = count;
        }                
        
        public string Format()
            => text.format(PSx4, EventId, ActorName, Host.Format(), AccessorCount);        
    }
}