//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using F = AsmOpCodeField;

    partial struct AsmOpCodes
    {
        /// <summary>
        /// Emits embedded opcode resources to a file
        /// </summary>
        /// <param name="dst">The target path</param>
        [Op]
        public static void emit(FS.FilePath dst)
            => emit(AsmOpCodes.dataset(), dst);


        [Op]
        public static void emit(FS.FolderPath root)
        {
            var data = AsmOpCodes.dataset();
            var count = data.OpCodeCount;
            var records = data.Entries.View;
            var identifers = data.Identity.View;
            insist(count, records.Length);
            insist(count, identifers.Length);
            var processor = new AsmOpCodePartitoner();
            var handler = group(count);
            processor.Partition(records, handler);
            emit(handler.Signatures, root + FS.file("asmsigs", FileExtensions.Csv));
            emit(handler.OpCodes, root + FS.file("opcodes", FileExtensions.Csv));
            emit(handler.Mnemonics, root + FS.file("mnemonics", FileExtensions.Csv));
        }

        public static void emit(ReadOnlySpan<AsmOpCode> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            writer.WriteLine("OpCode");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public static void emit(ReadOnlySpan<AsmMnemonic> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            writer.WriteLine("Mnemonic");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Name.Capacity));
            }
        }

        [Op]
        public static void emit(in AsmOpCodeDataset src, FS.FilePath dst)
        {
            var records = src.Entries.View;
            var count = src.OpCodeCount;
            var formatter = formatter<AsmOpCodeField>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(emit(record,formatter).Render());
            }
        }

        [Op]
        public static void emit(ReadOnlySpan<AsmSig> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        [Op]
        public static ref readonly DatasetFormatter<F> emit(in AsmOpCodeRow src, in DatasetFormatter<F> dst)
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
    }
}