//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static ProcessFx;

    using api = OldFlow;

    public readonly struct AsmTableSink : ITableSink<AsmTableSink, AsmRecord>
    {
        public IWfContext Wf {get;}

        readonly WfTableSink<AsmRecord>[] Sinks;
        
        public AsmTableSink(IWfContext context, params Receive<AsmRecord>[] receivers)
        {
            Wf = context;
            Sinks = receivers.Map(f => api.sink(context, f));
        }
        
        public void Deposit(in AsmRecord src)
        {
            
        }


        public void Deposit(ReadOnlySpan<AsmRecord> src)
        {

        }
    }
}