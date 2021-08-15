//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmTools.AsmToolNames;

    partial class AsmTools
    {
        [SymSource]
        public enum AsmToolKind : byte
        {
            None,

            [Symbol(nasm, "The Netwide assembler")]
            Nasm,

            [Symbol(masm, "The Microsoft masm assembler")]
            Masm,

            [Symbol(mc, "The LLVM mc assembler")]
            Mc
        }

        [LiteralProvider]
        public readonly struct AsmToolNames
        {
            public const string nasm = nameof(nasm);

            public const string masm = nameof(masm);

            public const string mc = nameof(mc);
        }
    }
}