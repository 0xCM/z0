//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-etl")]
        Outcome LlvmEtl(CmdArgs args)
        {
            var result = Outcome.Success;
            result = EmitLlvmRecords();
            TableEmit(LlvmOpCodes(), OpCodeSpec.RenderWidths, TableWs().LlvmTable<OpCodeSpec>());
            ImportLists(LlvmDatasetNames.TblgenLists, "llvm");
            GenLlvmStringTables();
            return result;
        }

        [CmdOp(".llvm-list-gen")]
        Outcome LlvmListGen(CmdArgs args)
        {
            var result = Outcome.Success;
            var path = Ws.Tools().Script(Toolspace.llvm_tblgen, ToolScriptId.emit_llvm_lists);
            result = RunToolScript(path, CmdVars.Empty, false, out var flow);
            ImportLists(LlvmDatasetNames.TblgenLists, llvm);
            return result;
        }

        void ImportLists(string dataset, string dstid)
        {
            var input = Ws.Sources().Datasets(dataset).Files(FS.List, true);
            var count = input.Length;
            var formatter = Tables.formatter<ListItemRecord>(ListItemRecord.RenderWidths);
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var members = items(src.ReadText().SplitClean(Chars.Comma).Select(x => x.Trim()).Where(text.nonempty).ToReadOnlySpan()).View;
                var mCount = members.Length;
                var dst = TableWs().Subdir(dstid) + FS.folder("lists") + src.FileName.ChangeExtension(FS.Csv);
                using var writer = dst.AsciWriter();
                writer.WriteLine(formatter.FormatHeader());
                for(var j=0; j<mCount; j++)
                {
                    ref readonly var member = ref skip(members,j);
                    var row = member.ToRecord(name);
                    writer.WriteLine(formatter.Format(row));
                }
                Write(FS.flow(src,dst));
            }
        }

        Outcome EmitLlvmRecords()
        {
            var result = Outcome.Success;
            var sources = LlvmRecords.Sources();
            EmitLines(sources.InstructionSummary.View, LlvmDatasets.Lined(LlvmDatasetKind.Instructions), TextEncodingKind.Asci);
            EmitLines(sources.IntrinsicsSummary.View, LlvmDatasets.Lined(LlvmDatasetKind.Intrinsics), TextEncodingKind.Asci);

            TableEmit(LlvmRecords.Defs(LlvmDatasetKind.Instructions, DefinesInstruction), DefRecord.RenderWidths, Ws.Tables().Subdir("llvm") + FS.file("x86.instructions.index",FS.Csv));
            TableEmit(LlvmRecords.Classes(LlvmDatasetKind.Instructions), ClassRecord.RenderWidths, Ws.Tables().Subdir("llvm") + FS.file("x86.classes.index",FS.Csv));

            TableEmit(LlvmRecords.Defs(LlvmDatasetKind.Intrinsics), DefRecord.RenderWidths, Ws.Tables().Subdir("llvm") + FS.file("llvm.intrinsics.index",FS.Csv));
            return result;
        }

        static bool DefinesInstruction(DefRecord src)
        {
            bit result = 1;
            result &= Enums.parse(src.Name, out AsmId dst);
            result &= (src.Ancestors.StartsWith("InstructionEncoding"));
            return result;
        }

        Outcome<uint> EmitLines(ReadOnlySpan<TextLine> src, FS.FilePath dst, TextEncodingKind encoding)
        {
            using var writer = dst.Writer(encoding);
            var count = (uint)src.Length;
            var emitting = EmittingFile(dst);
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(src,i));
            EmittedFile(emitting,count);
            return count;
        }

         void Emit(TableGenRecord src, FS.FilePath dst)
         {
            using var writer = dst.AsciWriter();
            foreach(var line in src.Lines)
            {
                writer.WriteLine(line.Content);
                Write(line);
            }

            Emitted(dst);

            if(src.Fields.Count != 0)
                iter(src.Fields, f => Write(f));
         }

    }
}