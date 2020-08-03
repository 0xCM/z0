//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct CapturingHosts : IWfEvent<CapturingHosts>
    {              
        const string Pattern = IdMarker + "Capturing data for {1} api hosts";
        
        public WfEventId Id {get;}

        public readonly IApiHost[] Hosts;

        public CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public CapturingHosts(IApiHost[] hosts, CorrelationToken? ct = null)
        {
            Ct = correlate(ct);
            Id = wfid(nameof(CapturingHosts), Ct);
            Hosts = hosts;
        }

        public readonly int HostCount
            => Hosts.Length;
        
        public string Format() 
            => text.format(Pattern, Id, HostCount);
    }    
}