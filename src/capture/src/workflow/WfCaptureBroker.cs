//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public sealed class WfCaptureBroker : WfBroker, IWfCaptureBroker
    {   
        public WfCaptureBroker(IWfEventLog log, CorrelationToken ct)
            : base(log, ct)
        {

        }

    }
}