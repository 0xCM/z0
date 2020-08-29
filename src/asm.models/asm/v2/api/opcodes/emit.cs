//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Tokens;

    using static Konst;
    using static z;
    using F = Z0.Asm.AsmOpCodeField;


    partial struct AsmOpCodes
    {
        /// <summary>
        /// Emits embedded opcode resources to a file
        /// </summary>
        /// <param name="dst">The target path</param>
        [Op]
        public static void emit(FS.FilePath dst)
        {
            var data = AsmOpCodes.dataset();
            var records = data.Entries.View;
            var count = data.OpCodeCount;
            var formatter = Tabular.Formatter<F>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);
            for(var i=0; i<count; i++)
                writer.WriteLine(format(skip(records,i), formatter));
        }

        [Op]
        static string format(in AsmOpCodeTable src, IDatasetFormatter<F> formatter)
        {
            formatter.Delimit(F.Sequence, src.Sequence);
            formatter.Delimit(F.Mnemonic, src.Mnemonic);
            formatter.Delimit(F.OpCode, src.OpCode);
            formatter.Delimit(F.Instruction, src.Instruction);
            formatter.Delimit(F.M16, src.M16);
            formatter.Delimit(F.M32, src.M32);
            formatter.Delimit(F.M64, src.M64);
            formatter.Delimit(F.CpuId, src.CpuId);
            formatter.Delimit(F.CodeId, src.CodeId);
            return formatter.Render();
        }
    }
}