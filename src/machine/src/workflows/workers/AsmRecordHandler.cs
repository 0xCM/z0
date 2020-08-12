//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Workers
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Flow;


    public readonly struct AsmRecordHandler : ITableMap<AsmRecordHandler, AsmRecord,AsmRecord>
    {
        public IWfContext Wf {get;}
        
        public AsmRecord Map(in AsmRecord src)
        {
            return src;
        }

        public void Process(ReadOnlySpan<AsmRecord> src)
        {

        }
    }
}