//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmExpr;

    [Record(TableId)]
    public struct AsmFormRecord : IRecord<AsmFormRecord>
    {
        public const string TableId = "asm.forms";

        public uint Seq;

        public OpCode OpCode;

        public Signature Sig;

        public TextBlock Expression;

    }
}