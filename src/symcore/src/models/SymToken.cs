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

        public const byte FieldCount = 7;

        public Identifier TokenType;

        public SymClass Class;

        public uint Index;

        public SymKey SymId;

        public Identifier Name;

        public SymExpr Expr;

        public TextBlock Description;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{24,16,8,8,18,18,64};
    }
}