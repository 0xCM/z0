//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static AsmEvents;

    public interface IMembersLocatedRelay : IEventBroker<HostMembersLocated>
    {
        HostMembersLocated MembersLocated => HostMembersLocated.Empty;
    }

}