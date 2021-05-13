//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct IceExtractors
    {
        [Op]
        public static AsmInstructionInfo summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmStatementExpr statement, uint offset)
            => new AsmInstructionInfo(@base, offset,  statement,  src.Specifier, code(encoded, offset, src.InstructionSize));

        [MethodImpl(Inline), Op]
        public static BinaryCode code(CodeBlock encoded, uint offset, byte size)
            => slice(encoded.View, offset, size).ToArray();
    }
}