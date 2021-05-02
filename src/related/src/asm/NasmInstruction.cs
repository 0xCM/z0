//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct NasmInstruction : IRecord<NasmInstruction>
    {
        public const string TableId = "nasm.instructions";

        public uint LineNumber;

        public CharBlock16 Mnemonic;

        public TextBlock Operands;

        public TextBlock Encoding;

        public TextBlock Flags;
    }
}