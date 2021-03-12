//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmFormRecord : IRecord<AsmFormRecord>
    {
        public const string TableId = "asm.forms";

        public const byte FieldCount = 4;

        public uint Seq;

        public AsmOpCodeExpr OpCode;

        public AsmSig Sig;

        public TextBlock Expression;
    }
}