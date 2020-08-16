//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public sealed class WfImmBroker : WfBroker, IWfImmBroker
    {        
        public WfImmBroker(CorrelationToken ct)
            : base(ct)
        {

        }

        public WfImmBroker(IWfContext wf, CorrelationToken ct)
            : base(ct)
        {

        }
    }    
}