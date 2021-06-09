//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AsmAssembly : IRecord<AsmAssembly>
    {
        public const string TableId = "asm.assembled";

        public uint SourceLine;

        public MemoryAddress Offset;

        public AsmExpr Statement;

        public BinaryCode Encoding;

        public TextBlock Bitstring;
    }
}