//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using static core;
    using static Root;

    [Record(TableId)]
    public struct McOpLogEntry
    {
        public const string TableId = "mc.ops-log";

        public string Semantic;

        public AsmExpr Expr;

        public string Encoding;

        public string Locator;

        public static ReadOnlySpan<byte> RenderWidths => new byte[4]{120,62,68,5};
    }

    partial class AsmCmdService
    {
        [CmdOp(".mc-logs")]
        Outcome McLog(CmdArgs args)
        {
            var result = Outcome.Success;
            CollectMcLogs();
            return result;
        }
   }
}