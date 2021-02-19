//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmExpr;

    [Record(TableId)]
    public struct AsmSpecifierRecord : IRecord<AsmSpecifierRecord>
    {
        public const string TableId = "asm.specifier";

        public uint Seq;

        public AsmExpr.Signature Sig;

        public OpCode OpCode;
    }
}