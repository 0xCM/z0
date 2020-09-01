//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static TableFunctions;

    using api = Flow;

    public readonly struct AsmTableSink : IWfTableSink<AsmTableSink, AsmRecord>
    {
        public IWfShell Wf {get;}

        readonly WfTableSink<AsmRecord>[] Sinks;

        public AsmTableSink(IWfShell context, params Receive<AsmRecord>[] receivers)
        {
            Wf = context;
            Sinks = receivers.Map(f => AB.tablesink(context, f));
        }

        public void Deposit(in AsmRecord src)
        {

        }

        public void Deposit(ReadOnlySpan<AsmRecord> src)
        {

        }
    }
}