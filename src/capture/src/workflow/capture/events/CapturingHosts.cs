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
        public readonly ApiHost[] Hosts;

        [MethodImpl(Inline)]
        public CapturingHosts(ApiHost[] hosts)
            => Hosts = hosts;

        public string Description
            => $"Capturing data for {Hosts.Length} api hosts";                
    }    
}