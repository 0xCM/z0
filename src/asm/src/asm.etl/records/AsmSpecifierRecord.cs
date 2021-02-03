//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmSpecifierRecord : IRecord<AsmSpecifierRecord>
    {
        public const string TableId = "asm.specifier";

        public uint Seq;

        public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;
    }
}