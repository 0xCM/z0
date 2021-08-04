//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-qasm-rex")]
        Outcome AsmQueryRex(CmdArgs args)
        {
            const string qid = "statements.rex";

            var counter = 0u;
            var result = LoadProcessAsm(out var records);
            if(!result)
                return result;

            var buffer = AsmGlobalSelection();
            buffer.Clear();
            var i = 0u;
            var count = AsmPrefixTests.rex(records, ref i, buffer);
            var filtered = slice(buffer,0,count);
            QueryOut(@readonly(filtered), Z0.ProcessAsm.RenderWidths, qid);
            return result;
        }

        [CmdOp(".api-qasm-vex")]
        Outcome AsmQueryVex(CmdArgs args)
        {
            const string qid = "statements.vex";

            var counter = 0u;
            var result = LoadProcessAsm(out var records);
            if(!result)
                return result;

            var buffer = AsmGlobalSelection();
            buffer.Clear();
            var i = 0u;
            var count = AsmPrefixTests.vex(records, ref i, buffer);
            var filtered = slice(buffer,0,count);
            QueryOut(@readonly(filtered), Z0.ProcessAsm.RenderWidths, qid);
            return result;
        }

    }
}