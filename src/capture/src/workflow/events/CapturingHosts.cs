//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;
    
    public readonly struct CapturingHosts : IWfEvent<CapturingHosts>
    {                      
        public const string EventName = nameof(CapturingHosts);
        
        public WfEventId EventId {get;}

        public readonly IApiHost[] Hosts;

        public readonly CellCount HostCount;        

        [MethodImpl(Inline)]
        public CapturingHosts(IApiHost[] hosts, CorrelationToken ct)
        {
            EventId = z.evid(EventName, ct);
            Hosts = hosts;
            HostCount = hosts.Length;
        }
        
        [MethodImpl(Inline)]
        public string Format() 
            => format(EventId, HostCount, Flow.delimit(Hosts));
    }    
}