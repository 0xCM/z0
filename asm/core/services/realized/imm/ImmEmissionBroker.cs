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

    public sealed class ImmEmissionBroker : EventBroker,  IImmEmissionStep
    {
        [MethodImpl(Inline)]
        public new static ImmEmissionBroker Create()
            => new ImmEmissionBroker();
    }
}