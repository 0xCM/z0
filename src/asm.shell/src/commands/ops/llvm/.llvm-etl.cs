//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using F = llvm.AsmRecordField;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-etl")]
        Outcome RunLlvmEtl(CmdArgs args)
        {
            var result = LlvmEtl.RunEtl(out var datasets);
            if(result.Fail)
                return result;

            var fields = datasets.AsmDefFields;
            var count = fields.Length;
            var dst = Ws.Tables().Subdir("llvm") + FS.file("fields", FS.Csv);
            var emitting = EmittingTable<F>(dst);
            const string FieldFormat = "{0,-32} | {1,-32} | {2,-32} | {3}";
            using var writer = dst.AsciWriter();
            writer.WriteLine(FieldFormat, nameof(F.Id), nameof(F.Type) , nameof(F.Name), nameof(F.Value));
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                writer.WriteLine(string.Format(FieldFormat, field.Id, field.Type, field.Name, field.Value));
            }

            EmittedTable(emitting, count);
            return result;
        }

        [CmdOp(".llvm-list-gen")]
        Outcome LlvmListGen(CmdArgs args)
            => LlvmEtl.GenLists();
    }
}