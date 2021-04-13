//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using Z0.Asm;

    public struct NasmInstruction : IRecord<NasmInstruction>
    {
        public const string TableId = "nasm.instructions";

        public uint LineNumber;

        public AsmMnemonic Mnemonic;

        public TextBlock Operands;

        public TextBlock Encoding;

        public TextBlock Flags;
    }
}