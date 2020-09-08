//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

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
            var formatter = Formatters.dataset<F>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(emit(record,formatter).Render());
                //writer.WriteLine(format(record, formatter));
            }
        }

        [Op]
        public static ref readonly DatasetFormatter<F> emit(in AsmOpCodeTable src, in DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.M16, src.M16);
            dst.Delimit(F.M32, src.M32);
            dst.Delimit(F.M64, src.M64);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }

        // [Op]
        // public static string format(in AsmOpCodeTable src, DatasetFormatter<F> dst)
        // {
        //     emit(src,dst);
        //     return dst.Render();
        // }
    }
}