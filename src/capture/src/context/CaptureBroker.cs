//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public sealed class CaptureBroker : WfBroker, ICaptureBroker
    {   
        [MethodImpl(Inline)]
        internal CaptureBroker(CorrelationToken ct)
            : base(ct)
        {

        }
    }
}