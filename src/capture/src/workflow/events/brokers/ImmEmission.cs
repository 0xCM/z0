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

    public interface IImmEmissionStep : IStepBroker, IEventBroker<EmittingImmTargets>
    {
        EmittingImmTargets EmittingImmTargets => EmittingImmTargets.Empty;

        EmittedImmRefinements EmittedImmRefinements => EmittedImmRefinements.Empty;

        HostFileEmissionFailed HostFileEmissionFailed => HostFileEmissionFailed.Empty;
    }
}