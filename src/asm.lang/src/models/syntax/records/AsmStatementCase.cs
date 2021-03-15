//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AsmStatementCase : IRecord<AsmStatementCase>
    {
        public const string TableId = "asm.statements.cases";

        public AsmStatementExpr Expression;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmHexCode Encoded;
    }
}