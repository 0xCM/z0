//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Record(TableId)]
    public struct McOpLogEntry
    {
        public const string TableId = "mc.ops-log";

        public AsmExpr Expr;

        public string Semantic;

        public FS.FileUri Source;

        public static ReadOnlySpan<byte> RenderWidths => new byte[3]{62,120,5};
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