//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturingHosts : IAppEvent<CapturingHosts>
    {              
        const string MessageTemplate = "Capturing data for $(HostCount) api hosts";
        
        public readonly IApiHost[] Hosts;

        [MethodImpl(Inline)]
        public CapturingHosts(IApiHost[] hosts)
            => Hosts = hosts;

        public readonly int HostCount
            => Hosts.Length;
        
        public string Format() 
            => $"Capturing data for {HostCount} api hosts";                
    }    
}