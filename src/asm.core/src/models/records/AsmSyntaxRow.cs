//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Record(TableId)]
    public struct AsmSyntaxRow
    {
        public const string TableId = "mc.ops-log";

        public LineOffset Location;

        public AsmExpr Expr;

        public string Syntax;

        public FS.FileUri Source;

        public static ReadOnlySpan<byte> RenderWidths => new byte[4]{12,62,120,5};
    }
}