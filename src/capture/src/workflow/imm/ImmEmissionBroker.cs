//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static AsmEvents;

    public sealed class ImmEmissionBroker : EventBroker<ImmEmissionBroker,IImmEmissionBroker>, IImmEmissionBroker
    {        
    
    }    

    public interface IImmEmissionBroker : IEventBroker
    {
        EmittedEmbeddedImm EmittedEmbeddedImm => EmittedEmbeddedImm.Empty;

        HostFileEmissionFailed HostFileEmissionFailed => HostFileEmissionFailed.Empty;

        ImmInjectionFailed ImmInjectionFailed => ImmInjectionFailed.Empty;
    }
}