//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public sealed class ImmBroker : WfBroker, IImmBroker
    {        
        public ImmBroker(CorrelationToken ct)
            : base(ct)
        {

        }

        public ImmBroker(IWfContext wf, CorrelationToken ct)
            : base(ct)
        {

        }
    }    
}