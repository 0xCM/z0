//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using Z0.Asm;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AsmFormRecord : IRecord<AsmFormRecord>
    {
        public const string TableId = "asm.forms";

        public uint Seq;

        public AsmOpCodeExpr OpCode;

        public AsmSigExpr Sig;

        public AsmFormExpr FormExpr;
    }
}