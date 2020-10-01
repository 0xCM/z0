//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    using F = Asm.AsmTableField;

    partial struct asm
    {
        public static string format(in AsmRow src, char delimiter = FieldDelimiter)
            => format(src, Formatters.dataset<F>(delimiter)).Render();

        public static ref readonly DatasetFormatter<AsmTableField> format(in AsmRow src, in DatasetFormatter<AsmTableField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.GlobalOffset, src.GlobalOffset);
            dst.Delimit(F.LocalOffset, src.LocalOffset);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.SourceCode, src.SourceCode);
            dst.Delimit(F.Encoded, src.Encoded);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.OpCodeId, src.OpCodeId);
            return ref dst;
        }
    }
}