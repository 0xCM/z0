//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static AsmEvents;

    public interface IImmEmissionRelay : IWorkflowRelay
    {
        EmittingImmInjections EmittingImmInjections => EmittingImmInjections.Empty;

    }

}