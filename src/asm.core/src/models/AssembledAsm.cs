//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [Record(TableId)]
    public struct AssembledAsm : IRecord<AssembledAsm>
    {
        public const string TableId = "asm.assembled";

        public uint SourceLine;

        public AsmExpr Expression;

        public MemoryAddress Offset;

        public BinaryCode Encoding;

        public AsmBitstring Bitstring;
    }
}