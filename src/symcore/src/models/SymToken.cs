//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct SymToken
    {
        public const string TableId = "tokens";

        public const byte FieldCount = 5;

        public Identifier TokenType;

        public SymKey Key;

        public Identifier Name;

        public SymExpr Expr;

        public TextBlock Description;

        public static ReadOnlySpan<byte> RenderWidths => new byte[FieldCount]{24,8,18,18,64};
    }
}