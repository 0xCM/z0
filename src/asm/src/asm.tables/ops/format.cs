//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using F = AsmRowField;

    partial struct AsmTables
    {
        [Op]
        public static ref readonly DatasetFormatter<AsmRowField> format(in AsmRow src, in DatasetFormatter<AsmRowField> dst)
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