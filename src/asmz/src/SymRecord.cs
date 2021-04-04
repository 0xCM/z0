//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Record(TableId)]
    public struct SymRecord : IRecord<SymRecord>
    {
        public const string TableId = "symdata";

        public const byte FieldCount = 9;

        public Identifier TypeName;

        public ushort SymCount;

        public SymKey Index;

        public Identifier Name;

        public SymExpr Expr;

        public ushort NameSize;

        public ushort ExprSize;

        public BinaryCode NameData;

        public BinaryCode ExprData;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{24,8,8,20,20,10,10,48,48};
    }
}